using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;

public class energy : MonoBehaviour
{
    public float energyCount = 9999;
    public TMPro.TMP_Text energyText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        energyCount -= Time.deltaTime;
        energyText.SetText("ENERGY: " + energyCount.ToString());
    }
}
