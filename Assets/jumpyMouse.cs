using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveDistance = 1f; // Total distance to move
    public float moveSpeed = 2f; // Speed of movement

    private Vector3 startPosition;
    private Vector3 endPosition;
    private bool movingToEnd = true;

    void Start()
    {
        // Store the initial position
        startPosition = transform.position;

        // Calculate the end position based on the move distance
        endPosition = startPosition + Vector3.up * moveDistance;
    }

    void Update()
    {
        // Calculate the target position based on the direction of movement
        Vector3 targetPosition = movingToEnd ? endPosition : startPosition;

        // Move towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Check if the platform has reached the target position
        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            // If the platform has reached the end position, switch direction
            if (movingToEnd)
                movingToEnd = false;
            else
                movingToEnd = true;
        }
    }
}
