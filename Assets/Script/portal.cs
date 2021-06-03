using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class portal : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D target)
    {
         if(target.tag == "brokoli" ||target.tag == "kol" || target.tag == "labu" || target.tag == "lobak" || target.tag == "terong" || target.tag == "tomat" || target.tag == "wortel" || target.tag == "Bomb")
        {
            Destroy(target.gameObject);
            //target.gameObject.SetActive(false);
        }
    }

}
