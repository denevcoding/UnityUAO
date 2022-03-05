using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GPlayer player = collision.gameObject.GetComponent<GPlayer>();


        if (player)
        {
            Debug.Log("Choque con player");
            player.Die();
        }
        

        Destroy(this.gameObject);
    }


   
}


