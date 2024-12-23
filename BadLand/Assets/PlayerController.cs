using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   

    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpStrength = 10f;
    private Rigidbody2D playerRigidbody;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        HandleMovement();
        HandleJump();
    }

    private void HandleMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 currentVelocity = playerRigidbody.velocity;
        playerRigidbody.velocity = new Vector2(horizontalInput * moveSpeed, currentVelocity.y);
    }

    private void HandleJump()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            playerRigidbody.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
        }
    }

    private bool IsGrounded()
    {
        
        return true; 
    }
}

