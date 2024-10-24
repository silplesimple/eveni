using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer spriteRenderer;
    [SerializeField]
    Sprite[] playerSprite;
    //float
    [SerializeField]
    PlayerMove playerMove;
    [SerializeField]
    Rotation rotation;
    [SerializeField]
    Transform playerMoveObj;
        
    public float moveInput;
    public float radius;
    public float playerSpeed = 0;

    private void Awake()
    {        
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        playerSpeed = 500f;
    }
    private void Start()
    {
        SetPlayerSprite(); 
    }

    private void Update()
    {
        InputPlayer();
    }

    private void InputPlayer()
    {
        moveInput = -Input.GetAxisRaw("Horizontal");

        PlayerSpriteFlip(moveInput);

        
        // 입력 검사
        
        moveInput *= playerSpeed*Time.deltaTime;
        
        if(moveInput!=0)
        {
            playerMove.Move(playerMoveObj,moveInput);
        }
        //Debug.Log()
    }

    private void PlayerSpriteFlip(float moveInput)
    {
        if(moveInput<0)
        {
            spriteRenderer.flipX = false;
        }
        else if(moveInput>0)
        {            
            spriteRenderer.flipX = true;
        }
    }
    //플레이어 스프라이트 설정
    private void SetPlayerSprite()
    {
        int RandomSpriteIndex = Random.Range(0, playerSprite.Length);        
        spriteRenderer.sprite = playerSprite[RandomSpriteIndex];
    }
}
