using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KVTorret : MonoBehaviour
{
    public float force;
    public GameObject bullet;
    public Transform aimer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Disparo");
            GameObject bulletTemp = Instantiate(bullet);
            bullet.transform.position = aimer.position;
        }
    }
}
