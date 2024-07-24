using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public const float MAXSPEED=5;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Vector2 vec2;
    float h;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    void Update()
    {
        //stop speed
        if(Input.GetButtonUp("Horizontal"))
        {            
            rigid.velocity = new Vector2(rigid.velocity.normalized.x*0.5f, rigid.velocity.y);
        }

        //Direction Sprite
        if(Input.GetButtonDown("Horizontal"))
        {
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Move speed
        h = Input.GetAxisRaw("Horizontal");             
        rigid.AddForce(Vector2.right*h,ForceMode2D.Impulse);

        //Max Speed
        if(rigid.velocity.x>MAXSPEED)
        {
            rigid.velocity = new Vector2(MAXSPEED,rigid.velocity.y);
        }
        else if(rigid.velocity.x<MAXSPEED*(-1))
        {
            rigid.velocity = new Vector2(MAXSPEED * (-1), rigid.velocity.y);
        }
        //Debug.Log(h);
        Debug.Log(rigid.velocity);
        
    }
}
