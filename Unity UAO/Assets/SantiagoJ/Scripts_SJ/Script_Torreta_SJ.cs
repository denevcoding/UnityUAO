using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Torreta_SJ : MonoBehaviour
{
    public float fuerzaDisparo;
    public GameObject bullet;
    public Transform aimer;
    public float speed;
    public GameObject player;
    public float accuracy;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am alive");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulletTemp = Instantiate(bullet);
            bulletTemp.transform.position = aimer.position;

            Vector3 dir = player.transform.position - aimer.transform.position;
            Debug.DrawLine(aimer.transform.position, dir, Color.blue, 5);
            dir.Normalize();
            Debug.DrawLine(aimer.transform.position, dir, Color.green, 5);
            dir *= fuerzaDisparo;

            Rigidbody rbBulletTemp = bulletTemp.GetComponent<Rigidbody>();
            rbBulletTemp.AddForce(dir, ForceMode.Force);
        }
    }

    public void Shoot(){
        GameObject bulletTemp = Instantiate(bullet);
        bulletTemp.transform.position = aimer.position;

        Vector3 dir = player.transform.position - aimer.transform.position;
        Debug.DrawLine(aimer.transform.position, dir, Color.blue, 5);
        dir.Normalize();
        Debug.DrawLine(aimer.transform.position, dir, Color.green, 5);
        dir *= fuerzaDisparo;

        Rigidbody rbBulletTemp = bulletTemp.GetComponent<Rigidbody>();
        rbBulletTemp.AddForce(dir, ForceMode.Force);
    }

    public bool IsAligned(Transform target)
    {
        Vector3 torretToTarget = target.position - aimer.position;
        float aligmentPercentage = Vector3.Dot(transform.right, torretToTarget.normalized);

        if (aligmentPercentage <= accuracy && aligmentPercentage >= -accuracy )
        {
            Debug.DrawLine(aimer.transform.position, target.position, Color.red);
            return true;
        }

        return false;
    }
}
