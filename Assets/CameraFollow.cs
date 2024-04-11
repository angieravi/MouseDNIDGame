using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Reference to the object to follow
    public float smoothSpeed = 0.125f; // Smoothness of camera movement

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + new Vector3(0, 0, -10); // Offset the camera to look at the target
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Smoothly interpolate between current and desired positions
            transform.position = smoothedPosition; // Update the camera position
        }
    }
}
