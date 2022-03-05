using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Torreta_SJ : MonoBehaviour
{
    public float fuerzaDisparo;
    public GameObject bullet;
    public Transform aimer;
    public float speed;

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

            Rigidbody rbBulletTemp = bulletTemp.GetComponent<Rigidbody>();
            rbBulletTemp.AddForce(aimer.forward * fuerzaDisparo, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
    }
}
