using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sayur_Jatuh : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        screenBounds = Camera.main.ScreenToViewportPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.x < screenBounds.x)
        //{
        //    Destroy(this.gameObject);
        //}   
    }
    private void Awake()
    {
        //if (transform.position.y < screenBounds.y)
        //{
        //    Destroy(this.gameObject);
        //}
    }
}
