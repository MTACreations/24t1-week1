using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingHazard : MonoBehaviour
{
    public float speed;
    public GameObject type;
    public PlayerMovement player;
    [SerializeField] private Animator anim;


    void FixedUpdate()
    {
        if (type.tag == "HazardKick")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(speed, 0, 0);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-speed, 0, 0);
        }
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

    async public void OnTriggerEnter2D(Collider2D other)
    {
        if (type.tag == "HazardAttack")
        {
            if (other.tag == "Attack")
            {
                anim.SetBool("Death", true);

                speed = -1;
                await Task.Delay(600);
                Destroy(gameObject);

            }

        }

        if (type.tag == "HazardKick")
        {
            Physics2D.IgnoreLayerCollision(6, 7);

            if (other.tag == "Kick")
            {

                speed = 0;
                anim.SetBool("Death", true);
                await Task.Delay(600);
                Destroy(gameObject);

            }

        }
    }
}
