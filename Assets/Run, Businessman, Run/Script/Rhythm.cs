using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhythm : MonoBehaviour
{
    public float time = 0;
    public float timeLimit;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;
        Debug.Log(time);

        if (time >= timeLimit)
        {
            time = 0;
            Debug.Log("Beat!");

        }
    }
}
