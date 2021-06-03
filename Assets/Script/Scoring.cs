using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    private Text scoreText;
    private int score = 0;
    //   private Image healthPoint;
    // private int bantuan = 5;

    public GameObject[] heart;
    private int life;
    private bool dead;

    private void Start()
    {
        //life = heart.Length;
        life = 3;
        //for(int i = 0; i<3; i++)
        //heart[i].gameObject.SetActive(true);
        Debug.Log(life.ToString());
    }

    private void Awake()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        scoreText.text = "0";
        
        
    
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "wortel")
        {
            //target.gameObject.SetActive(false);
            Destroy(target.gameObject);
            score += 10;
            scoreText.text = score.ToString();
        }
        if (target.tag == "brokoli")
        {
            //target.gameObject.SetActive(false);
            Destroy(target.gameObject);
            score += 15;
            scoreText.text = score.ToString();
        }
        if (target.tag == "kol")
        {
            //target.gameObject.SetActive(false);
            Destroy(target.gameObject);
            score += 5;
            scoreText.text = score.ToString();
        }
        if (target.tag == "tomat")
        {
            //target.gameObject.SetActive(false);
            Destroy(target.gameObject);
            score += 50;
            scoreText.text = score.ToString();
        }
        if (target.tag == "labu")
        {
            //target.gameObject.SetActive(false);
            Destroy(target.gameObject);
            score += 100;
            scoreText.text = score.ToString();
        }
        if(target.tag == "terong")
        {
            //target.gameObject.SetActive(false);
            Destroy(target.gameObject);
            score += 20;
            scoreText.text = score.ToString();
        }
        //boosting item
        //if (target.tag == "lobak")
        //{
        //    target.gameObject.SetActive(false);
        //    if(life <= 4)
        //    {
        //        heart[life - 1].gameObject.SetActive(true);
        //        life++;
        //    }
        //}
        if (target.tag == "Bomb")
        {
            //target.gameObject.SetActive(false);
            Destroy(target.gameObject);
            if (life >= 1)
            {
                heart[life-1].gameObject.SetActive(false);
                life--;

                Debug.Log(life.ToString());

            }
            else
            {
                Debug.Log("Anda Mati");
            }            

        }
    }

}//class












