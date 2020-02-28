using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.GetChild(0).position;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Rigidbody2D>().bodyType == RigidbodyType2D.Dynamic)
        {
            transform.GetChild(0).position = startPosition;
        }
    }
}
