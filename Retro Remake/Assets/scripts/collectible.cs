using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class collectible : MonoBehaviour
{
    public energy energy;
    public objective objective;
    public int hpReset = 9999;
    public float hpChange = 1000;
    public bool isGoal = false;
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

        if (isGoal == true)
        {
            objective.objectiveCount += 1;
            print("link what are you doing go save hyrule");
            Destroy(gameObject);
        }
    }
}
