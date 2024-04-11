using UnityEngine;

public class UpDownPlatform : MonoBehaviour
{
    public float speed = 2f; // Speed of the platform's movement
    public float minY = 0f; // Minimum y position
    public float maxY = 5f; // Maximum y position

    private bool movingUp = true;

    void Update()
    {
        // Calculate the next position based on the movement direction
        float nextY = transform.position.y + (movingUp ? speed * Time.deltaTime : -speed * Time.deltaTime);

        // Ensure the platform stays within the specified range
        nextY = Mathf.Clamp(nextY, minY, maxY);

        // Update the platform's position
        transform.position = new Vector3(transform.position.x, nextY, transform.position.z);

        // If the platform reaches the upper or lower limit, change direction
        if (nextY >= maxY || nextY <= minY)
        {
            movingUp = !movingUp;
        }
    }
}
