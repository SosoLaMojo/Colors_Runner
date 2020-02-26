using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowers : MonoBehaviour
{

    Rigidbody2D body;
    Vector2 direction;
    [SerializeField] float jumpForce;
    [SerializeField] bool canJump;
    [SerializeField] const float fallModifier = 1.15f;
    bool isGoingRight = true;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

        if (Input.GetButtonDown("GreenPower"))
        {
            GreenPower();
        }
        
        else if (Input.GetButtonDown("BluePower"))
        {
            BluePower();
        }
        
        else if (Input.GetButtonDown("YellowPower"))
        {
            YellowPower();
            if (isGoingRight)
            {
                isGoingRight = false;
            }
            
            else if (!isGoingRight)
            {
                isGoingRight = true;
            }
        }

        FallingModifier();

        if (body.velocity.x < 5 && isGoingRight)
        {
            body.velocity = new Vector2(5, body.velocity.y);
        }
        
        else if (body.velocity.x > -5 && !isGoingRight)
        {
            body.velocity = new Vector2(-5, body.velocity.y);
        }
    }

    void GreenPower()
    {
        if (canJump)
        {
            direction = new Vector2(body.velocity.x, jumpForce); 
            body.velocity = direction;
            canJump = false;
        }
    }
    
    void BluePower()
    {
        
    }
    
    void YellowPower()
    {
        direction = new Vector2(body.velocity.x * -1, body.velocity.y);
        body.velocity = direction;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            canJump = true;
        }
    }

    void FallingModifier()
    {
        if (body.velocity.y <= 0)
        {
            direction = new Vector2(body.velocity.x, body.velocity.y * fallModifier); 
            body.velocity = direction;
        }
    }
}