using UnityEngine;

public class CandyCollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Perform item collection logic
            CollectCandy();

            // Destroy the collectible object
            Destroy(gameObject);
        }
    }

    private void CollectCandy()
    {
        Debug.Log("Candy collected!");
        // Add logic here to handle what happens when candy is collected
    }
}
