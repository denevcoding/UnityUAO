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
       Player Player = collision.gameObject.GetComponent<Player>();

        if (Player)
        {
            Debug.Log("choque con un pendejo");
            Player.Die();
        }

        Destroy(this.gameObject);
    }
}
