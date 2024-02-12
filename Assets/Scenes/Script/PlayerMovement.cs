using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public bool jumped;
    public bool kicked;
    public bool crouched;
    public bool attacked;

    public float rhythmInput;
    public Rhythm rhythm;
    public GameObject attack;
    public GameObject kick;

    public void Update()
    {
        if (rhythm.time < rhythmInput)
        {
            if (Input.GetKey("w") == true)
            {
                Jump();
            }

            if (Input.GetKey("a") == true)
            {
                Kick();
            }

            if (Input.GetKey("s") == true)
            {
                Crouch();
            }

            if (Input.GetKey("d") == true)
            {
                Attack();
            }
        } else {
            kicked = false;
            attacked = false;
            kick.SetActive(false);
            attack.SetActive(false);

            Debug.Log("Actions Reset");
        }
    }

    public void Jump()
    {
        Debug.Log("Jumped!");
        jumped = true;
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, 10, 0);
    }

    public void Kick()
    {
        Debug.Log("Kicked!");
        kicked = true;
        kick.SetActive(true);
    }

    public void Crouch()
    {
        Debug.Log("Crouched!");
        crouched = true;
    }

    public void Attack()
    {
        Debug.Log("Attacked!");
        attacked = true;
        attack.SetActive(true);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Portal")
        {
            SceneManager.LoadScene("Game");
        }

        if (other.tag == "Goal")
        {
            SceneManager.LoadScene("Win");
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Ground" && jumped == true)
        {
            jumped = false;
        }
    }
}
