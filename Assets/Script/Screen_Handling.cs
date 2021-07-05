using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screen_Handling : MonoBehaviour
{
    public string screen;
    public Canvas canva;
    public int charac;
    public void OpenMenuScene()
    {
        charac = 0;
        SceneManager.LoadScene(screen);
        Debug.Log("TerClick");
    }
    public void OpenMenuScene1()
    {
        charac = 1;
        SceneManager.LoadScene(screen);
        Debug.Log("TerClick");
    }
    public void closesAplication()
    {
        
        Application.Quit();
    }
    public void OpenMenuSceneStoped()
    {

        SceneManager.LoadScene(screen);
        Time.timeScale = 1f;
        Debug.Log("TerClick");
    }
    public void closeFromPause()
    {
        SceneManager.LoadScene(screen);
        Time.timeScale = 1f;
        Debug.Log("TerClick");
        canva.gameObject.SetActive(false);
    }
}
