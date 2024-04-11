using UnityEngine;

public class TeaCollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Perform item collection logic
            CollectTea();

            // Destroy the collectible object
            Destroy(gameObject);
        }
    }

    private void CollectTea()
    {
        Debug.Log("Tea collected!");
    }
}
