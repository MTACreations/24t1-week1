using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickHazardSpawner : MonoBehaviour
{
    public float time = 0;
    public float timeLimit = 5;
    public GameObject Hazard;

    void Start()
    {

    }

    void FixedUpdate()
    {
        time += Time.deltaTime;
        Debug.Log(time);

        if (time >= timeLimit)
        {
            Instantiate(Hazard);
            time = 0;
            Debug.Log("Summoned Kick Enemy!");
        }
    }
}
