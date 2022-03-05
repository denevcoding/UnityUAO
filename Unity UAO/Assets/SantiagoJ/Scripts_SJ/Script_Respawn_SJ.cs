using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Respawn_SJ : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            player.transform.position = transform.position;
            player.SetActive(true);
            player.transform.eulerAngles = new Vector3(0, 90, 0);
        }
    }
}
