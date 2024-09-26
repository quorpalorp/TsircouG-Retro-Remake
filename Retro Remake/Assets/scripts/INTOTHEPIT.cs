using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class INTOTHEPIT : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Fazbear Frights - Into The Pit");
        Debug.Log("'NOOO!!! NOT INTO THE PIT!'' -Ganondorf, about to be hit by the first Fazbear Frights book");
    }
}
