using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int roundCount;      //whole number
    public float xPosition;     //precise number
    public string beeMovie;     //text
    public bool isTargetDead;   //true - false statement
    public Vector2 targetLoc;   //2d number (e.g. position)

    //called on first frame
    void Start()
    {
        Debug.Log("SOMEONES STEALING THE CASHOUT WHAT ARE YOU DOING TAKE IT BACK (you have " + beeMovie + " chances left)");

        if (isTargetDead)
        {
            Debug.Log("HAHAHHAHAHAHAHH LOSER");
        }
        else
        {
            Debug.Log("you know aimlabs is free right");
        }
    }

    //called every frame
    void Update()
    {

    }
}