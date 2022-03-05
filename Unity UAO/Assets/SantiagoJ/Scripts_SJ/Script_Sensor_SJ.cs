using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Sensor_SJ : MonoBehaviour
{
    public Script_Torreta_SJ torreta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Script_Player_SJ>())
        {
            Debug.Log("Entro al trigger " + other.gameObject.name);
            
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<Script_Player_SJ>())
        {
            Script_Player_SJ playerTarget = other.gameObject.GetComponent<Script_Player_SJ>();
            if (torreta.IsAligned(playerTarget.gameObject.transform))
            {
                Debug.Log("Tolerado");
                torreta.Shoot();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Salio dle trigger " + other.gameObject.name);
    }
}
