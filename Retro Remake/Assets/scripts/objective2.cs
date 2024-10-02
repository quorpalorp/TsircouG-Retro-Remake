using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class objective2 : MonoBehaviour
{
    public static int objectiveCount;

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
      //  objectiveCount += 1;
        //print("current count: " + objectiveCount);
   // }
    void Update()
    {
        if (objectiveCount == 3)
        {
            SceneManager.LoadScene("you did it yay");
            print("you did it yey");
        }
    }
}
