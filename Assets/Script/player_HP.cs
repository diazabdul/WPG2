using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public int Hp ;
    public int numOfHeart ;

    public Image[] health;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Update()
    {
        for(int i = 0; i<health.Length; i++)
        {
            if (i < numOfHeart)
            {

            }
        }
    }
}
