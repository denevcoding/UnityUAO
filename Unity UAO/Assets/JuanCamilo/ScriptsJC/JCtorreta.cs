using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JCtorreta : MonoBehaviour
{

    public float force;
    public GameObject bullet;
    public Transform Aimer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()       
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("shoot");
            GameObject bullettemp = Instantiate(bullet);
            bullet.transform.position = Aimer.position;


        }
      
    }
}
