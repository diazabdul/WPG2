using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    
    private Text scoreText;
    private Text hasilAkhir;
    private int score = 0;
    //   private Image healthPoint;
    // private int bantuan = 5;
    public Canvas ampas;
    public Canvas closes;
    public GameObject[] heart;
    private int life;
    public bool counter;
    private portal port;

    public void Start()
    {

        //life = heart.Length;
        life = heart.Length - 1;
        //for(int i = 0; i<3; i++)
        //heart[i].gameObject.SetActive(true);
        heart[3].gameObject.SetActive(false);

    }
    private void Update()
    {
        
        if(port.score >= 100 && life >= 1)
        {
            heart[life - 1].gameObject.SetActive(false);
            life -= 1;

            port.score -= 100;

            if(life == 0)
            {
                Debug.Log("Anda Mati");
                hasilAkhir.text = score.ToString();
                closes.enabled = false;
                ampas.enabled = true;
                Time.timeScale = 0f;
            }
        }


    }
    //public void Update()
    //{



    //    //if (life <= 4)
    //    //{
    //    //    switch (life)
    //    //    {
    //    //        case 0:
    //    //            heart[0].gameObject.SetActive(false);
    //    //            heart[1].gameObject.SetActive(false);
    //    //            heart[2].gameObject.SetActive(false);
    //    //            Debug.Log("Anda Matin");
    //    //            break;
    //    //        case 1:
    //    //            heart[0].gameObject.SetActive(true);
    //    //            heart[1].gameObject.SetActive(false);
    //    //            heart[2].gameObject.SetActive(false);

    //    //            break;
    //    //        case 2:
    //    //            heart[0].gameObject.SetActive(true);
    //    //            heart[1].gameObject.SetActive(true);
    //    //            heart[2].gameObject.SetActive(false);

    //    //            break;
    //    //        case 3:
    //    //            heart[0].gameObject.SetActive(true);
    //    //            heart[1].gameObject.SetActive(true);
    //    //            heart[2].gameObject.SetActive(true);

    //    //            break;


    //    //    }
    //    //}
    //}

    private void Awake()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        scoreText.text = "0";
        hasilAkhir = GameObject.Find("scoreAkhir").GetComponent<Text>();
        port = GameObject.FindObjectOfType<portal>();
       
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
        if (target.tag == "lobak")
        {
            Destroy(target.gameObject);
         
            if (life  < 4)
            {
                heart[life].gameObject.SetActive(true);
                life+=1;
            }
        }
        if (target.tag == "Bomb")
        {
            //target.gameObject.SetActive(false);
            Destroy(target.gameObject);
            if (life > 1)
            {         

                heart[life - 1].gameObject.SetActive(false);
                life -= 1;

            }
            else if(life==1)
            {

                heart[life - 1].gameObject.SetActive(false);
                Debug.Log("Anda Mati");
                hasilAkhir.text = score.ToString();
                closes.enabled = false;
                ampas.enabled = true;
                Time.timeScale = 0f;
            }
            

        }
    }
    

}//class












