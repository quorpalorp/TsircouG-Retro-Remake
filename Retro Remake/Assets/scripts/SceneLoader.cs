using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScreen(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("SCENE [" + sceneName + "] LOADED");
    }

    public void Quit()
    {
        Debug.Log("APPLICATION HUNG. REASON: WITCHCRAFT");
        Application.Quit();
    }
}
