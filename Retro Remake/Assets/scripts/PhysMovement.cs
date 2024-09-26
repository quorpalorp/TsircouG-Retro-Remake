using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PhysMovement : MonoBehaviour
{
    //keycodes!!!!!!!!!!!!!!!!
    public KeyCode left = KeyCode.A, right = KeyCode.D, up = KeyCode.W, down = KeyCode.S;
    public float speed = 10;
    public bool hasNoMass = false;

    private Rigidbody2D _rb2d;

    void Start() //Start is called before the first frame update
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()  // Update is called once per frame
    {
        // sets the velocity to zero every frame if true
        if (hasNoMass == true)
        {
           _rb2d.velocity = Vector2.zero;
        }
        
        if (Input.GetKey(left))
        {
           _rb2d.velocity = Vector2.left * speed;
        }
        if (Input.GetKey(right))
        {
            _rb2d.velocity = Vector2.right * speed;
        }
        if (Input.GetKey(up))
        {
            _rb2d.velocity = Vector2.up * speed;
        }
        if (Input.GetKey(down))
        {
            _rb2d.velocity = Vector2.down * speed;
        }
    }
}
