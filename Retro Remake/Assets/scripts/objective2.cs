using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class objective2 : MonoBehaviour
{
    public int objectiveCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        objectiveCount += 1;
    }
    void Update()
    {
        if (objectiveCount == 3)
        {
            SceneManager.LoadScene("you did it yay");
        }
    }
}
