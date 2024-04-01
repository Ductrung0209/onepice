using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vegetta : MonoBehaviour
    
{
    public float speed;
    private isfacingRight = true;
    private float Right_Left;
    private Rigidbody2D rb;
    private Animator anim;

      void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        Right_Left = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Right_Left * speed, rb.velocity.y);
        Backup();
        anim.SetFloat("move", Mathf.Abs(Right_Left));
        if(Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Attack");
        }
        if (Input.GetMouseButtonUp(1))
        {

        }
    }
}
