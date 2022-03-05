using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APTorreta : MonoBehaviour
{
    public float force;
    public GameObject bullet;
    public Transform aimer;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){

            Shoot();

        }
    }

    public void Shoot()
    {
        //Debug.Log("Shot");
        GameObject bulletTemp = Instantiate(bullet);
        bullet.transform.position = aimer.position;

        Rigidbody rBullet = bulletTemp.GetComponent<Rigidbody>();

        Vector3 forceVector = player.transform.position - aimer.transform.position;

        Debug.DrawLine(aimer.transform.position, player.transform.position, Color.green, 5f);
        forceVector.Normalize();

        forceVector *= force;

        //Vector3 shootForce = aimer.right * force;

        rBullet.AddForce(forceVector, ForceMode.Impulse);
    }

    //public bool CalculateAlignment()
    //{


    //}
}
