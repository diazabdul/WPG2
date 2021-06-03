using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Cabai : MonoBehaviour
{

    public float increase = 5f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject player = collision.gameObject;
            Movement_player playerScript = player.GetComponent<Movement_player>();

            if (playerScript)
            {
                playerScript.ms += increase;
            }
        }
    }
}
