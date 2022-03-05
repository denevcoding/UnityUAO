using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
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
        KVPlayer player = collision.gameObject.GetComponent<KVPlayer>();
        if (player)
        {
            //Debug.Log("Choque con player");
            player.Die();
        }

        Destroy(this.gameObject);
    }
}
