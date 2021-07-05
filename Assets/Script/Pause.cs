using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    //public GameObject pauseMenu;
    public Canvas canva;
    public Canvas book;
    public Canvas ahm;
    public GameObject go;
    public void pauseGame()
    {
        canva.enabled = true;
        canva.gameObject.SetActive(true);
        
        Time.timeScale = 0f;
    }
    public void resumeGame()
    {
        canva.gameObject.SetActive(false);
        
        Time.timeScale = 1f;
    }

    public void openBook()
    {
        book.enabled = true;
        book.gameObject.SetActive(true);
        ahm.gameObject.SetActive(false);
        Time.timeScale = 0f;
    }
    public void closeBook()
    {
        ahm.enabled = true;
        book.gameObject.SetActive(false);
        ahm.gameObject.SetActive(true);
        Time.timeScale = 1f;
    }
}
