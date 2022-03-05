using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESB_SC_Torreta : MonoBehaviour
{
    public float force;
    public GameObject bullet;
    public Transform aimer;

    public GameObject player;
 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparar();
            

        }
        
        
    }

    public void Disparar()
    {
        GameObject bullettemp = Instantiate(bullet);
        bullet.transform.position = aimer.position;


        Rigidbody rbBullet = bullettemp.GetComponent<Rigidbody>();

        Vector3 dir = player.transform.position - aimer.transform.position;
        dir.Normalize();
        dir *= force;

        Debug.DrawLine(aimer.transform.position, player.transform.position, Color.cyan, 5f);


        rbBullet.AddForce(dir, ForceMode.Impulse);
    }

   
}
