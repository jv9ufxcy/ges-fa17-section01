using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float jumpStrength = 1f;

    [SerializeField]
    float movementSpeed = 1f;

    [SerializeField]
    Transform groundDetectPoint;

    [SerializeField]
    float groundDetectRadius = 0.2f;

    [SerializeField]
    LayerMask whatCountsAsGround;

    private bool isOnGround;

    Rigidbody2D myRigidbody;
	// Use this for initialization
	void Start ()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateIsOnGround();
        Move();
        Jump();
    }

    private void UpdateIsOnGround()
    {
        Collider2D[] groundObjects = Physics2D.OverlapCircleAll(groundDetectPoint.position, groundDetectRadius, whatCountsAsGround);

        isOnGround = groundObjects.Length > 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOnGround = true;
    }
    private void Jump()
    { 
        if (Input.GetButtonDown("Jump")&& isOnGround)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpStrength);
            isOnGround = false;
        }
    }

    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        myRigidbody.velocity = new Vector2(horizontalInput * movementSpeed, myRigidbody.velocity.y);
        Debug.Log("Horizontal input: " + horizontalInput);
    }
}
