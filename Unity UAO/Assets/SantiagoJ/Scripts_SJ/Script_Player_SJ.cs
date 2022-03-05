using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Player_SJ : MonoBehaviour
{
    public float speed;
    public float fuerzaSalto;
    bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
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
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canJump)
            {
                transform.Translate(0, speed * Time.deltaTime * 10, 0);
                Debug.Log("Salto!");
                canJump = false;
            } 
        }
        if (!canJump)
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        canJump = true;
    }

    public void Die() {
        gameObject.SetActive(false);
        float timer = 5f;
        timer -= Time.deltaTime;
        if (timer<=0)
        {
            gameObject.SetActive(true);
        }
    }
}
