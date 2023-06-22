using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTriger : MonoBehaviour
{
    public Transform checkpoint;
    public PlayerMovment movment;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            transform.position = checkpoint.position;
        }
        if (collisionInfo.collider.tag == "Finish")
        {
            movment.enabled = false;
        }
    }
}
