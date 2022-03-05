using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JCbullet : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter (Collision collision)
    {
        JCplayer player = collision.gameObject.GetComponent<JCplayer>();

        if (player)
        {
            Debug.Log("Choque con player");
            player.Die();
        }

        Destroy(this.gameObject);

    }

   
}
