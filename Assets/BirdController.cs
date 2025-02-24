using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce = 5f;
    public GameObject gameOverPanel; // Game over UI

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            GameOver();
        }
        else if (collision.gameObject.CompareTag("Pipe"))
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over!");
        Time.timeScale = 0; // 
    }
}
