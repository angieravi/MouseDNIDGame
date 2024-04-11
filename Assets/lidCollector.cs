using UnityEngine;

public class LidCollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Perform item collection logic
            CollectLid();

            // Destroy the collectible object
            Destroy(gameObject);
        }
    }

    private void CollectLid()
    {
        Debug.Log("Lid collected!");
    }
}
