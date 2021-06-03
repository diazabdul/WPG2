using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    //public GameObject pauseMenu;
    public Canvas canva;

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
}
