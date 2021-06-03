using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_PLUS : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        health_Control.health -= 1;
    }
}
