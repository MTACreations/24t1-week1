using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingHazard : MonoBehaviour
{
    public float speed;
    public GameObject type;
    public PlayerMovement player;

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(-speed, 0, 0);
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (type.tag == "HazardCrouch")
        {
            if (other.collider.tag == "Player")
            {
                if (player.crouched == false)
                {
                    SceneManager.LoadScene("Fail");
                }
            }
        }

        if (other.collider.tag == "Player")
        {
            SceneManager.LoadScene("Fail");
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (type.tag == "HazardAttack")
        {
            if (other.tag == "Attack")
            {
                Destroy(gameObject);
            }
        }

        if (type.tag == "HazardKick")
        {
            if (other.tag == "Kick")
            {
                Destroy(gameObject);
            }
        }
    }
}
