using UnityEngine;

public class appleCollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Perform item collection logic
            CollectItem();

            // Destroy the item object
            Destroy(gameObject);
        }
    }

    private void CollectItem()
    {
        Debug.Log("Item collected!");
    }
}
