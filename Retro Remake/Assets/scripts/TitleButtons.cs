using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtons : MonoBehaviour
{
    public void Play()
    {
        Debug.Log("MAIN MAP LOADED");
        SceneManager.LoadScene("main map");
    }

    public void Quit()
    {
        Debug.Log("APPLICATION HUNG (REASON: WITCHCRAFT)");
        Application.Quit();

    }

}
