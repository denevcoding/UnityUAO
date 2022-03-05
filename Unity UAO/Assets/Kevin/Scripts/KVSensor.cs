using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KVSensor : MonoBehaviour
{
    public KVTorret torreta;
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
        
      
    }



  private void OnTriggerStay(Collider other)
    {
        KVPlayer playerTarget = other.gameObject.GetComponent<KVPlayer>();
        //Debug.Log("Triggeriando" + other.gameObject.name);
        if (playerTarget)
        {//El objeeto que entro es player
            if (torreta.IsAlignToTarget(playerTarget.gameObject.transform))
            {//La torreta y el player estan alineados
                Debug.Log("ALINEADOS ");
                //torreta.Shoot();
            }
           
        }
    }

    /*
  private void OnTriggerExit(Collider other)
  {
      Debug.Log("Salio el trigger " + other.gameObject.name);
  }*/
}
