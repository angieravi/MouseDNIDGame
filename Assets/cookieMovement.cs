using UnityEngine;

public class CookieCollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Perform item collection logic
            CollectCookie();

            // Destroy the collectible object
            Destroy(gameObject);
        }
    }

    private void CollectCookie()
    {
        Debug.Log("Cookie collected!");
        // Add logic here to handle what happens when candy is collected
    }
}
