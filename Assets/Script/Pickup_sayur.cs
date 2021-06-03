using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_sayur : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            pickup();
        }
    }

    void pickup()
    {
        Debug.Log("Terambil");
    }
}
