using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESB_SC_Sensor : MonoBehaviour
{
    public GameObject torreta;

    void Start()
    {
        
    }

    // Update is called once per frameS
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.GetComponent<ESB_SC_Player>())
        {
            torreta.GetComponent<ESB_SC_Torreta>().Disparar();
        }
    }


}
