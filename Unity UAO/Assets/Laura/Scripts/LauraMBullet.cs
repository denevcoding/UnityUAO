using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauraMBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnCollisionEnter(Collision other){

       LauraMPlayer player = other.gameObject.GetComponent<LauraMPlayer>();
        if(player){
            Debug.Log("Choque con el Player");
            player.Die();
        }
        
        Destroy(this.gameObject);

    }
        
    
}
