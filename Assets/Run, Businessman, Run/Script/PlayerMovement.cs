using System.Threading.Tasks;
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
    [SerializeField] private float x;
    [SerializeField] private Animator anim;
    [SerializeField] AudioSource levelComplete;
    [SerializeField] AudioSource jumping;
    [SerializeField] AudioSource punching;

    public void FixedUpdate()
    {
        if (rhythm.time < rhythmInput)
        {
            Jump();
            Kick();
            Crouch();
            Attack();

        }
        else
        {
            jumped = false;
            kicked = false;

            attacked = false;
            kick.SetActive(false);
            attack.SetActive(false);

            Debug.Log("Actions Reset");
        }
    }

    public void Jump()
    {
        if (Input.GetKey("w") == true)
        {

            Debug.Log("Jumped!");
            jumped = true;
            jumping.Play();
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, x, 0);
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }
    }

    public void Kick()
    {
        if (Input.GetKey("a") == true)
        {
            Debug.Log("Kicked!");
            kicked = true;
            punching.Play();
            kick.SetActive(true);
            anim.SetBool("Back Punch", true);
        }
        else
        {
            anim.SetBool("Back Punch", false);
        }
    }

    public void Crouch()
    {
        if (Input.GetKey("s") == true)
        {
            Debug.Log("Crouched!");
            crouched = true;
            jumping.Play();
            anim.SetBool("Slide", true);
        }
        else
        {
            anim.SetBool("Slide", false);
        }
    }

    public void Attack()
    {
        if (Input.GetKey("d") == true)
        {
            Debug.Log("Attacked!");
            attacked = true;
            punching.Play();
            attack.SetActive(true);
            anim.SetBool("Punch", true);
        }
        else
        {
            anim.SetBool("Punch", false);
        }
    }

    async public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Portal")
        {
            levelComplete.Play();
            await Task.Delay(800);
            SceneManager.LoadScene("Level 1");
        }

        if (other.tag == "Goal")
        {
            levelComplete.Play();
            await Task.Delay(800);
            SceneManager.LoadScene("Win");
        }
    }

}

