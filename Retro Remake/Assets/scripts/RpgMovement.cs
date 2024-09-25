using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RpgMovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed = 10;
    public KeyCode up = KeyCode.W;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
        if (Input.GetKey(KeyCode.W))
        {
            rb2d.position = transform.up *= speed;
        }
    }
}