using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APSensor : MonoBehaviour
{
    public APTorreta torreta;

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
        Debug.Log("Entro el trigger" + other.gameObject.name);
        torreta.Shoot();
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Activao" + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Salio del trigger" + other.gameObject.name);
    }
}
