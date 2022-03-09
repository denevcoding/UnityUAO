using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauraMTorreta : MonoBehaviour
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
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject bulletTemp = Instantiate(bullet);
            bullet.transform.position = aimer.position;

            Rigidbody rbBullet = bulletTemp.GetComponent<Rigidbody>();

            Vector3 dir = player.transform.position - aimer.transform.position;
            dir.Normalize();
            dir = dir * force;

            Vector3 shootForce = dir;
            rbBullet.AddForce(shootForce, ForceMode.Impulse);
        
        }
    }
}
