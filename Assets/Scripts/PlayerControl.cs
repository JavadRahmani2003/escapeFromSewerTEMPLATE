using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 6f; // Speed of the player
    public float jumpForce = 10f; // Force of the jump
    public LayerMask groundLayer; // Layer that defines what is ground
    public GameObject player;
    public AudioSource bgmusic;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }

    private void Jump()
    {
        // Check if the player is grounded using a raycast
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.5f, groundLayer);

        // Allow jumping only if the player is grounded
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
    
    public void diePlayer()
    {
        Destroy(this);
        player.SetActive(false);
        bgmusic.Stop();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
