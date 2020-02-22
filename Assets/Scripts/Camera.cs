using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject player;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + 5.5f, 0, -10);
    }
}
