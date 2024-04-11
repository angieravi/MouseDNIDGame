using UnityEngine;

public class CheeseCollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Perform item collection logic
            CollectCheese();

            // Destroy the collectible object
            Destroy(gameObject);
        }
    }

    private void CollectCheese()
    {
        Debug.Log("Cheese collected!");
        // Add logic here to handle what happens when candy is collected
    }
}
