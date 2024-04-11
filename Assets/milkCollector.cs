using UnityEngine;

public class MilkCollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Perform item collection logic
            CollectMilk();

            // Destroy the collectible object
            Destroy(gameObject);
        }
    }

    private void CollectMilk()
    {
        Debug.Log("Milk collected!");
    }
}
