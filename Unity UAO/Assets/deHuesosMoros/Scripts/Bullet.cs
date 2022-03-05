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
        Player1 player = collision.gameObject.GetComponent<Player1>();
        if (player)
        {
            Debug.Log("Choque con player");
            player.Die();
        }

        Destroy(this.gameObject);

    }

   
}
