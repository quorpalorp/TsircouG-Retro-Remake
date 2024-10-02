using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class collectiblestuff : MonoBehaviour
{
    public energy energy;
    //public int objectiveCount;
    public int hpReset = 9999;
    public float hpChange = 1000;
    //public bool isGoal = false;
    public bool isReset = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isReset == true)
        {
            energy.energyCount = hpReset;
            print("shlurp");
            Destroy(gameObject);
        }
        else
        {
            energy.energyCount += hpChange;
            print("shlurp");
            Destroy(gameObject);
        }

       // if (isGoal == true)
        //{
          //  objectiveCount += 1;
            //print("link what are you doing go save hyrule");
            //Destroy(gameObject);
        //}
    }
}
