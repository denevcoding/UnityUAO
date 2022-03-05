using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JCSensor : MonoBehaviour
{

    public JCtorreta torreta;
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
        if (other.gameObject.GetComponent<JCplayer>())

        Debug.Log("entro el trigger" + other.gameObject.name);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Triggeriando" + other.gameObject.name);
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Salio el trigger" + other.gameObject.name);
    }
}

