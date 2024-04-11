using UnityEngine;

public class StrawCollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Perform item collection logic
            CollectStraw();

            // Destroy the collectible object
            Destroy(gameObject);
        }
    }

    private void CollectStraw()
    {
        Debug.Log("Straw collected!");
        // Add logic here to handle what happens when candy is collected
    }
}
