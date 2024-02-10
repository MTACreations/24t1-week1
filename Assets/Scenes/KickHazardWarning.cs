using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickHazardWarning : MonoBehaviour
{
    public float time = 1;
    public float timeLimit = 5;
    public GameObject Warning;

    void FixedUpdate()
    {
        time += Time.deltaTime;
        Debug.Log(time);

        if (time >= 1)
        {
            Warning.SetActive(false);
        }

        if (time >= timeLimit)
        {
            Warning.SetActive(true);
            time = 0;
        }
    }
}
