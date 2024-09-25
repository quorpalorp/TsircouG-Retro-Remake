using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class energy : MonoBehaviour
{
    public int energyCount = 9999;
    public TMPro.TMP_Text energyText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        energyText.SetText("ENERGY: " + energyCount.ToString());
    }
}
