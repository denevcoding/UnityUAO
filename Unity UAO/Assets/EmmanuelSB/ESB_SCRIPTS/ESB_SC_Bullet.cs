using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESB_SC_Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update(){ }

    private void OnCollisionEnter(Collision collision)
    {
        ESB_SC_Player player = collision.gameObject.GetComponent<ESB_SC_Player>();
            if (player)
    {
       Debug.Log("Choque con player");
            //player.Die();

    }
        //Destroy(this.gameObject);


    }

}
