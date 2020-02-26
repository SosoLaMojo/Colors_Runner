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
        }
        
        else if (Input.GetButtonDown("RedPower"))
        {
            RedPower();
        }
        
        FallingModifier();
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
    
    void RedPower()
    {
        
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