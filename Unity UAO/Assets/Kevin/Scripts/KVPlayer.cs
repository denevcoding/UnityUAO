using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KVPlayer : MonoBehaviour
{
    CharacterController controller;
    Vector3 movementVector;
    Animator animator;


    bool isRunning = false;

    public float speed;


    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();


        movementVector = Vector3.zero;
    }

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Debug.Log("hAxis: " + hAxis);
        Debug.Log("vAxis: " + vAxis);

        movementVector.x = hAxis;
        movementVector.y = 0f;
        movementVector.z = vAxis;

        if (movementVector.x == 0 && movementVector.z == 0)
        {
            isRunning = false;
        }
        else
        {
            isRunning = true;
        }



        move();

        HandleAnimation();
    }

    public void HandleAnimation()
    {
        animator.SetBool("isRunning", isRunning);
    }

    public void move()
    {
        controller.SimpleMove(movementVector * (speed * Time.deltaTime));
    }

    public void Die()
    {
        gameObject.SetActive(false);   
    }
}
