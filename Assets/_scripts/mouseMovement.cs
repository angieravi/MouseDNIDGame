using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class mouseMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private bool isGrounded;

    public LayerMask groundLayer;
    public Transform[] collectibles; // collectible objects
    private bool allCollected = false; // track if all collectibles are collected

    private Rigidbody2D rb;
    private BoxCollider2D boxCollider2D;

    public float smoothness = 5f; // smoothness
    public float fallThreshold = -6f; // fall threshold

    public GameObject nextLevelButton;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();

        rb.freezeRotation = true;

        collectibles = GameObject.FindGameObjectsWithTag("cookie").Select(obj => obj.transform).ToArray();
    }

    void Update()
    {
        if (!allCollected) // If all collectibles are not collected
        {
            Move();
            Jump();
            CheckOutOfBounds();
        }

        else
        {
            // Enable the next level button once all collectibles are collected
            if (nextLevelButton != null)
            {
                nextLevelButton.SetActive(true);
            }
        }
    }

    void Move()
    {
        if (allCollected) return; // Stop moving if all collectibles are collected

        float moveInput = Input.GetAxis("Horizontal");
        Vector2 targetVelocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        rb.velocity = targetVelocity; // Assign target velocity directly
    }

    void Jump()
    {
        if (allCollected) return; // Stop jumping if all collectibles are collected

        if ((Input.GetKeyDown(KeyCode.UpArrow) && isGrounded) || IsCollidingWithPlatform())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false; // Player is no longer grounded after jumping
        }
    }

    bool IsCollidingWithPlatform()
    {
        // Cast a ray upwards to check for collisions with platforms
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 0.1f, groundLayer);
        return hit.collider != null;
    }

    void FixedUpdate()
    {
        isGrounded = IsGrounded();
    }

    bool IsGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }

    void CheckOutOfBounds()
    {
        if (!allCollected && transform.position.y < fallThreshold)
        {
            Debug.Log("OutOfBounds! Reloading scene...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("cookie"))
        {
            collectibles = collectibles.Where(c => c != other.transform).ToArray();

            if (collectibles.Length == 0)
            {
                allCollected = true;
                Debug.Log("All items collected!");
                rb.velocity = Vector2.zero;
            }

            Destroy(other.gameObject);
        }
        else if (other.CompareTag("mainhand"))
        {
            Debug.Log("Hit main hand! Reloading scene...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
