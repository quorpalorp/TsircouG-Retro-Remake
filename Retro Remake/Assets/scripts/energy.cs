using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;

public class energy : MonoBehaviour
{
    public float energyCount = 9999;
    public TMPro.TMP_Text energyText;

    // Update is called once per frame
    void Update()
    {
        energyCount -= Time.deltaTime;
        energyText.SetText("ENERGY: " + energyCount.ToString());
    }
}
