using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESB_SC_Player : MonoBehaviour

{
    public float fuerza;
    bool isGrounded;
    bool isDobleSalto = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            if (isGrounded)
            {//Estoy en el suelo
                Saltar(true);
            }
            else
            {//Esto en el aire
                if(isDobleSalto)
                {
                    Saltar(false);
                }
            }
            

            
        }
    }

    public void Die()
    {

        gameObject.SetActive(false);
    }

    public void Saltar(bool firstime)
    {
        Vector3 salto = this.gameObject.GetComponent<Transform>().up * fuerza;
        this.gameObject.GetComponent<Rigidbody>().AddForce(salto, ForceMode.Impulse);
        if (firstime)
        {
            isDobleSalto = true;
        }
        else
        {
            isDobleSalto = false;
        }
       
    }
}
