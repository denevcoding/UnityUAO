using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KVTorret : MonoBehaviour
{
    public float force;
    public float accuracy;
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
        Debug.DrawLine(aimer.transform.position, forceVector + aimer.transform.position, Color.green, 5f);

        rbBullet.AddForce(forceVector, ForceMode.Impulse);
    }


    public bool IsAlignToTarget(Transform targetPos)
    {
 
        Vector3 torretToTarget = targetPos.position - aimer.transform.position;

        
        float alignmentPercetange = Vector3.Dot(aimer.transform.forward, torretToTarget.normalized);

        if (alignmentPercetange >= (accuracy * -1) && alignmentPercetange <= accuracy)
        {
            Debug.Log(torretToTarget.magnitude);
            Debug.DrawLine(aimer.transform.position, torretToTarget + aimer.transform.position, Color.green);

            
            return true;
        }

        

        return false;
    }
}
