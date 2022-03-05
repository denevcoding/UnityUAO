using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Bullet_SJ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 2);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Script_Player_SJ player = collision.gameObject.GetComponent<Script_Player_SJ>();
        if (collision.gameObject.GetComponent<Script_Player_SJ>())
        {
            Debug.Log("Choque con el jugador");
            player.Die();
        }
        Destroy(gameObject, 1);

    }
}
