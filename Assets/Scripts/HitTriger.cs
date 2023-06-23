using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene(0);
        }
    }
}
