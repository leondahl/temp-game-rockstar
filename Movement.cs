using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D playerBody;
    public float playerMovementX;
    public float playerJumpHeight = 3;
    public bool isJumping;
	void Start ()
    {
        playerBody = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate ()
    {
        playerMovementX = Input.GetAxis("Horizontal");
        playerBody.transform.position = (playerBody.position + new Vector2(playerMovementX / 2, 0));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            if (isJumping == true)
            {
                isJumping = false;
                playerBody.velocity = playerBody.velocity + new Vector2(0, playerJumpHeight * 3);
            }
        }
	}
}
