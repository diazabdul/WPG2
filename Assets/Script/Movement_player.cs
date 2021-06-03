using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_player : MonoBehaviour
{
    Rigidbody2D Rb;
    public float ms;
    SpriteRenderer kiri;
    // Start is called before the first frame update
    Animator anim;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        kiri = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxisRaw("Horizontal");
        Rb.velocity = new Vector2(ms * horiz, Rb.velocity.y);

        if (Input.GetKey(KeyCode.A))
        {
            kiri.flipX = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            kiri.flipX = false;
        }
    }
    void ayu_kiri()
    {
        anim.SetTrigger("ayu_kiri");
    }
}
