using UnityEngine;

public class ClickToDisappear : MonoBehaviour
{
    private static bool clicked = false;

    private void Start()
    {
        if (clicked)
        {
            gameObject.SetActive(false); // Hide the object if it was previously clicked
        }
    }

    private void OnMouseDown()
    {
        if (!clicked)
        {
            // Hide the object
            gameObject.SetActive(false);
            clicked = true;
        }
    }

    public static void ResetClickedState()
    {
        clicked = false;
    }
}
