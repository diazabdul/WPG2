using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_Character : MonoBehaviour
{

    public GameObject[] heart;
    private int life;
    private bool dead;

    // Start is called before the first frame update
    void Start()
    {
        life = heart.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if(dead == true)
        {
            Debug.Log("Anda Mati");
        }
    }

    public void takeDamage (int d)
    {
        if(life >= 1)
        {
            life -= d;
            Destroy(heart[life].gameObject);
            if (life < 1)
            {
                dead = true;
            }
        }
    }
}
