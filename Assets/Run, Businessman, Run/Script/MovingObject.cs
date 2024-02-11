using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingObject : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(-speed, 0, 0);
    }
}