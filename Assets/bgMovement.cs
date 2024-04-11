using UnityEngine;

public class bgMovement : MonoBehaviour
{
    public float scrollSpeed = 1f;
    private Renderer backgroundRenderer;

    void Start()
    {
        backgroundRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Scroll the background texture continuously
        float offset = Time.time * scrollSpeed;
        Vector2 textureOffset = new Vector2(offset, 0);
        backgroundRenderer.material.mainTextureOffset = textureOffset;
    }
}
