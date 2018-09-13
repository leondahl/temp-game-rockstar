using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Pointers for the components.
    Rigidbody2D playerBody;
    BoxCollider2D boxColl2D;
    public float playerMovementX;
    public bool isJumping;
    public bool isGrounded;
	void Start ()
    {
        playerBody = GetComponent<Rigidbody2D>();
        boxColl2D = GetComponent<BoxCollider2D>();
	}

    void FixedUpdate()
    {
        //Makes the player move around using A and D or the Left Arrow and Right arrow
        playerMovementX = Input.GetAxis("Horizontal");
        playerBody.transform.position = (playerBody.position + new Vector2(playerMovementX / 5.5f, 0));
        //Checks if the player presses Space and can jump. If true, they jump.
        if (Input.GetButtonDown("Jump") && isJumping == false && isGrounded == true)
        {
            isJumping = true;
            if (isJumping == true && isGrounded == true)
            {
                isJumping = false;
                isGrounded = false;
                playerBody.velocity = playerBody.velocity + new Vector2(0, 7);
            }
            else if (isJumping == false || isGrounded == false)
            {
                print("Fail");
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Checks if the player is on the ground or not
        if (boxColl2D == collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
