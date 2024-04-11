using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton2 : MonoBehaviour
{
    // Name of the scene to load
    public string nextSceneName = "Ending";

    // Called when the sprite is clicked
    private void OnMouseDown()
    {
        Debug.Log("Button Clicked!"); // Debug log added
        // Load the next scene
        SceneManager.LoadScene(nextSceneName);
    }
}
