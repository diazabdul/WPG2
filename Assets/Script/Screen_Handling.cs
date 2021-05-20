using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screen_Handling : MonoBehaviour
{
    public string screen;
    public void OpenMenuScene()
    {
        SceneManager.LoadScene(screen);
        Debug.Log("TerClick");
    }
}
