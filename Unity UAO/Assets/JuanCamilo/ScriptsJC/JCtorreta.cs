using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JCtorreta : MonoBehaviour
{

    public float force;
    public GameObject bullet;
    public Transform Aimer;

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
            shoot();
        }

    }

    public void shoot()
    {
        Debug.Log("shoot");
        GameObject bullettemp = Instantiate(bullet);
        bullettemp.transform.position = Aimer.position;

        Rigidbody rbBullet = bullettemp.GetComponent<Rigidbody>();

        Vector3 dir = player.transform.position - Aimer.transform.position;

        Debug.DrawLine(Aimer.transform.position, player.transform.position, Color.blue, 5f);
        dir.Normalize();


        //dir = dir * force;
        dir *= force;
        //Vector3 shootForce = Aimer.right * force;
        rbBullet.AddForce(dir, ForceMode.Impulse);




    }

    public bool IsAlignToTarget (Transform targetpos)
    {
        bool IsAlignment = false;
        Vector3 TorretToTarget = Vector3.zero;

        float AlignmentPercentage = Vector3.Dot(Aimer.transform.right, TorretToTarget);

        return IsAlignment;
    }

}
