using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KVTorret : MonoBehaviour
{
    public float force;
    public GameObject bullet;
    public Transform aimer;
    public GameObject Player;



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

            Rigidbody rBullet = bulletTemp.GetComponent<Rigidbody>();
            Vector3 shootForce = aimer.right * force;
            rBullet.AddForce(shootForce, ForceMode.Impulse);

            Vector3 Dir = Player.transform.position - aimer.transform.position;

            Debug.DrawLine(aimer.transform.position, Player.transform.position, Color.green, 5f);
            Dir.Normalize();
            Dir = Dir * force;


        }
    }
}
