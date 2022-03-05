using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APBala : MonoBehaviour
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

        APPlayer player = collision.gameObject.GetComponent<APPlayer>();
        if (player)
        {
            Debug.Log("Shoke con player");
            player.Die();
        }

        //Destroy(this.gameObject);
    }
}
