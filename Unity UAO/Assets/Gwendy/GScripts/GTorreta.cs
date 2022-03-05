using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GTorreta : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }


    public void Shoot()
        {

        Debug.Log("Disparo");
        GameObject bulletTemp = Instantiate(bullet);
        bulletTemp.transform.position = aimer.position;

        Rigidbody rbBullet = bulletTemp.GetComponent<Rigidbody>();

        Vector3 forceVector = player.transform.position - aimer.transform.position;


        forceVector.Normalize();

        forceVector *= force;

        Debug.DrawLine(aimer.transform.position, player.transform.position, Color.green, 5f);
        //Vector3 shootForce = aimer.forward * force;
        rbBullet.AddForce(forceVector, ForceMode.Impulse);
    }
    public bool IsAlingToTarget(Transform targetPos)
        bool isAlignment = false;
    Vector3 torretToTarget = TargetPos.position - aimer.transform.position;
    float alignmentPercentage = Vector3.Dot(Transform.right, torretToTarget)
}