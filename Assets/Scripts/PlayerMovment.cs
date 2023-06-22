using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardspeed = 1000f;
    public float sidespeed = 100f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardspeed * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidespeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidespeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
