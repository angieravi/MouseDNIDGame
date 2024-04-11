using UnityEngine;

public class ClickToDisappear2 : MonoBehaviour
{
    private static bool clicked = false;

    private void Start()
    {
        if (clicked)
        {
            this.gameObject.SetActive(false); // Hide the object if it was previously clicked
        }
    }

    private void OnMouseDown()
    {
        if (!clicked)
        {
            // Hide the object
            this.gameObject.SetActive(false);
            clicked = true;
        }
    }
}


