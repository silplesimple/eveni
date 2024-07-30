using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameManager gameManager;
    public const float MAXSPEED=5;
    public float jumpPower;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    CapsuleCollider2D capsuleCollider;
    Vector2 vec2;
    float h;
    Animator anim;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        //Jump
        if(Input.GetButtonDown("Jump")&& !anim.GetBool("isJumping"))
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            Debug.Log(anim.GetBool("isJumping"));
            anim.SetBool("isJumping", true);
            Debug.Log(anim.GetBool("isJumping"));
        }
        //stop speed
        if(Input.GetButtonUp("Horizontal"))
        {            
            rigid.velocity = new Vector2(rigid.velocity.normalized.x*0.5f, rigid.velocity.y);
        }

        //Direction Sprite
        if(Input.GetButton("Horizontal"))
        {
            bool Flipxtrigger= Input.GetAxisRaw("Horizontal") == -1;
            spriteRenderer.flipX = Flipxtrigger;
        }

        if(Mathf.Abs( rigid.velocity.x)<0.3f)
        {
            anim.SetBool("isWalking",false);
        }
        else
        {
            anim.SetBool("isWalking", true);
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
        //Debug.Log(rigid.velocity);

        //Landing Platform
        if(rigid.velocity.y<0)
        {
            Debug.DrawRay(rigid.position, Vector3.down, new Color(0, 1, 0));

            RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Platform"));

            if (rayHit.collider != null)
            {
                if (rayHit.distance < 0.5f)
                {
                    anim.SetBool("isJumping", false);
                }
            }
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Item")
        {
            //point
            bool isBronze = collision.gameObject.name.Contains("Bronze");
            bool isSilver= collision.gameObject.name.Contains("Silver");
            bool isGold= collision.gameObject.name.Contains("Gold");
            if(isBronze)
            {
                gameManager.stagePoint += 50;
            }
            else if(isSilver )
            {
                gameManager.stagePoint += 100;
            }
            else if(isGold)
            {
                gameManager.stagePoint += 300;
            }
            collision.gameObject.SetActive(false);
        }
        else if(collision.gameObject.tag=="Finish")
        {
            //Next Stage
            gameManager.NextStage();
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            if(rigid.velocity.y<0&&transform.position.y>collision.transform.position.y)
            {
                OnAttack(collision.transform);
            }
            else
            {
            OnDamaged(collision.transform.position);                          
            }
            //Debug.Log("플레이어가 맞았습니다.");
        }
    }

    void OnAttack(Transform enemy)
    {
        //point
        gameManager.stagePoint += 100;
        //Reaction Force
        rigid.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
        //Enemy Die
        EnemyMove enemyMove = enemy.GetComponent<EnemyMove>();
        enemyMove.OnDamaged();
    }
    void OnDamaged(Vector2 targetPos)
    {
        //Health Down
        gameManager.HealthDown();
        //Change Layer(Immortal Active)
        gameObject.layer = 11;

        //View Alpha
        spriteRenderer.color = new Color(1, 1, 1, 0.4f);        
        //Reaction Force
        int dirc = transform.position.x - targetPos.x > 0 ? 1 : -1;
        rigid.AddForce(new Vector2(dirc,1)*7, ForceMode2D.Impulse);

        //Animation
        anim.SetTrigger("Damaged");
        Invoke("OffDamaged", 3);
    }

    void OffDamaged()
    {
        gameObject.layer = 10;

        spriteRenderer.color = new Color(1, 1, 1, 1f);
    }

    public void OnDie()
    {
        //Sprite Alpha
        spriteRenderer.color = new Color(1, 1, 1, 0.4f);
        //Sprite Flip Y
        spriteRenderer.flipY = true;
        //Collider Disable
        capsuleCollider.enabled = false;
        //Die Effect jump
        rigid.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
    }

    public void VelocityZero()
    {
        rigid.velocity = Vector2.zero;
    }
}
