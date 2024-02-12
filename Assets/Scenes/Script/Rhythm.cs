using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhythm : MonoBehaviour
{
    public float time = 0;
    public float deactivateBeep;
    public float timeLimit = 1;
    public GameObject Beep;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;
        Debug.Log(time);

        if (time >= deactivateBeep)
        {
            time = 0;
            Beep.SetActive(false);
        }

        if (time >= timeLimit)
        {
            time = 0;
            Debug.Log("Beat!");
            Beep.SetActive(true);
        }
    }
}
