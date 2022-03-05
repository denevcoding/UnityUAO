using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Torreta_SJ : MonoBehaviour
{
    public float fuerzaDisparo;
    public GameObject bullet;
    public Transform aimer;

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
        }
    }
}
