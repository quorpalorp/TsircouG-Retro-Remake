using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    public static objective2 objective2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        objective2.objectiveCount += 1;
        print("current count: " +  objective2.objectiveCount);
        Destroy(gameObject);
    }
}
