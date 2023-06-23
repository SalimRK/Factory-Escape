using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;
    public Animator animator;

    public float forwardspeed = 1000f;
    public float sidespeed = 100f;

    private bool isMovingLeft = false;
    private bool isMovingRight = false;

    void UpdateAnimation()
    {
        animator.SetBool("SprintLeft", isMovingLeft);
        animator.SetBool("SprintRight", isMovingRight);
    }

    // Update is called once per frame
    void FixedUpdate()
    {  
        rb.AddForce(0, 0, forwardspeed * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidespeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            isMovingRight = true;
            isMovingLeft = false;
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidespeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            isMovingLeft = true;
            isMovingRight = false;
        }
        else
        {
            isMovingLeft = false;
            isMovingRight = false;
        }
        if (Input.GetKey("p"))
        {
            SceneManager.LoadScene(0);
        }

        UpdateAnimation();
    }
}
