using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleWall : MonoBehaviour
{

    void OnCollisionStay2D(Collision2D other)
    {
        if (Input.GetButtonDown("RedPower"))
        {
            Destroy(gameObject);
        }
    }
}
