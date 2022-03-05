using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void Die ()
    {
       
        gameObject.SetActive(false);
        //Destroy(this.gameObject);
    }

}
