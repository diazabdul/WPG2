
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class portal : MonoBehaviour
{
    
    public int score = 0;
   // public GameObject[] heart;
    private int life;
    private void Start()
    {
    //    life = heart.Length;
        
    }

    private void Awake()
    {
        
    }
    private void Update()
    {
       
        
        //if (score >= 100)
        //{

        //    heart[life - 1].gameObject.SetActive(false);
        //    Debug.Log("Nyawa Kurang 1");
        //    score -= 100;

        //    life -= 1;
        //}

    }

    void OnTriggerEnter2D(Collider2D target)
    {
        // if(target.tag == "brokoli" ||target.tag == "kol" || target.tag == "labu" || target.tag == "lobak" || target.tag == "terong" || target.tag == "tomat" || target.tag == "wortel" || target.tag == "Bomb")
        //{
        //    Destroy(target.gameObject);
        //    //target.gameObject.SetActive(false);
        //}
        if(target.tag == "brokoli")
        {
            score += 8;
            Destroy(target.gameObject);
            Debug.Log("Jatuh Brokol");
            
        }
        if (target.tag == "kol")
        {
            score += 3;
            Destroy(target.gameObject);
            Debug.Log("Jatuh Kol");
            Debug.Log(score);
            
        }
        if (target.tag == "labu")
        {
            score += 50;
            Destroy(target.gameObject);
            Debug.Log("Jatuh Labu");
            Debug.Log(score);
            
        }
        if (target.tag == "lobak")
        {
            Destroy(target.gameObject);
            Debug.Log("Jatuh Lobak");
            Debug.Log(score);
            
        }
        if (target.tag == "terong")
        {
            score += 10;
            Destroy(target.gameObject);
            Debug.Log("Jatuh Terong");
            Debug.Log(score);
            
        }
        if (target.tag == "tomat")
        {
            score += 25;
            Destroy(target.gameObject);
            Debug.Log("Tomat");
            Debug.Log(score);
            
        }
        if (target.tag == "wortel")
        {
            score += 5;
            Debug.Log("Jatuh Wortel");
            Debug.Log(score);
            
        }
        if (target.tag == "bomb")
        {
            Destroy(target.gameObject);
            Debug.Log("Jatuh");
        }
        
    }
    

}
