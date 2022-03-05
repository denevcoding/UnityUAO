using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba1 : MonoBehaviour
{
    public float force;
    public GameObject bullet;
    public Transform aimer;
    public Player1 player;

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
            bulletTemp.transform.position = aimer.position;

            Rigidbody rbBullet = bulletTemp.GetComponent<Rigidbody>();

            Vector3 forceVector = player.transform.position - aimer.transform.position;

            Debug.DrawLine(aimer.transform.position, player.transform.position, Color.green, 5f);
            forceVector.Normalize();

            forceVector *= force;
            rbBullet.AddForce(forceVector,ForceMode.Impulse);

        }     
        
    }
}
