using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;

public class energy : MonoBehaviour
{
    public float energyCount = 9999;
    public TMPro.TMP_Text energyText;
    public float energyDrain = 1;

    // Update is called once per frame
    void Update()
    {
        energyCount -= Time.deltaTime * energyDrain;
        energyText.SetText("ENERGY: " + energyCount.ToString());
    }
}
