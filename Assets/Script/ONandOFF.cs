using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONandOFF : MonoBehaviour
{
    private Canvas gamo;
    SpriteRenderer render;
    private bool tas;
    public GameObject[] tombol;
    // Start is called before the first frame update
    void Start()
    {
        tombol[0].gameObject.SetActive(true);
        tombol[1].gameObject.SetActive(false);
    }

    public void on()
    {
        if (tombol[0].gameObject.active == true)
        {
            tombol[0].gameObject.SetActive(false);
            tombol[1].gameObject.SetActive(true);
        }else if(tombol[1].gameObject.active == true)
        {
            tombol[1].gameObject.SetActive(false);
            tombol[0].gameObject.SetActive(true);
        }
    }
    public void closes()
    {
        for(int i= 0; i<tombol.Length; i++)
        {
            tombol[i].gameObject.SetActive(false);
        }
    }

    
}
