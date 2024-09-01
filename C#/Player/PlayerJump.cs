using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool isGrounded = false;
    public LayerMask groundLayer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float minValue = 2.5f;
        float maxValue = 10f;
        float randomFloat = Random.Range(minValue, maxValue);
        jumpForce = randomFloat;
        isGrounded = Physics2D.Raycast(transform.position,Vector2.down,1f,groundLayer);
        if (Input.GetKeyDown(KeyCode.Space)&&isGrounded)
        {
            Jump();
        }
        if (Input.GetButtonDown("Jump")&&isGrounded)  //手柄
        {
            Jump();
        }
    }
    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x,jumpForce);
    }
}
