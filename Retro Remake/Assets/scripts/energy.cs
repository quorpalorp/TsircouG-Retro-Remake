using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class energy : MonoBehaviour
{
    public static float energyCount = 30;
    public float deathThreshold = 0;
    public TMPro.TMP_Text energyText;
    public float energyDrain = 1;

    // Update is called once per frame
    void Update()
    {
        energyCount -= Time.deltaTime * (energyDrain / 2);
        energyText.SetText("ENERGY: " + energyCount.ToString());

        if (energyCount <= deathThreshold)
        {
            SceneManager.LoadScene("you died lol");
            Debug.Log("AHAHAHHAHHAHAHAH YOU DIED");
        }
    }
}
