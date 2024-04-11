using UnityEngine;
using UnityEngine.SceneManagement;

public class mainhandScript : MonoBehaviour
{
    // Other variables and methods from your existing script...

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("mainhand"))
        {
            ResetGame();
        }
    }

    void ResetGame()
    {
        // Reset the game by reloading the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
