using UnityEngine;

public class WaterCollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Perform item collection logic
            CollectWater();

            // Destroy the collectible object
            Destroy(gameObject);
        }
    }

    private void CollectWater()
    {
        Debug.Log("Water collected!");
        // Add logic here to handle what happens when candy is collected
    }
}
