using UnityEngine;

public class Dispawner : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "HazardAttack")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "HazardJump")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "HazardCrouch")
        {
            Destroy(other.gameObject);
        }
    }
}
