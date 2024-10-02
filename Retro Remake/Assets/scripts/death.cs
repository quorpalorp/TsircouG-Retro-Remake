using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    public static energy energy;
    public float deathThreshold = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (energy.energyCount == deathThreshold)
        {
            SceneManager.LoadScene("you died lol");
            Debug.Log("AHAHAHHAHHAHAHAH YOU DIED");
        }
    }
}
