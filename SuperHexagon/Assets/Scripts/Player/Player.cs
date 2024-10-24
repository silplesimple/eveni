using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Random = UnityEngine.Random;

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

    public event Action OnDeath;
        
    public float moveInput;
    public float radius;
    public float playerSpeed = 0;

    private void Awake()
    {        
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        playerSpeed = 300f;
    }
    private void Start()
    {
        SetPlayerSprite(); 
    }

    private void Update()
    {
        InputPlayer();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Ʈ���� ��");
        CallDeathEvent();
    }

    private void CallDeathEvent()
    {
        OnDeath?.Invoke();
    }

    private void InputPlayer()
    {
        moveInput = -Input.GetAxisRaw("Horizontal");

        PlayerSpriteFlip(moveInput);

        
        // �Է� �˻�
        
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
    //�÷��̾� ��������Ʈ ����
    private void SetPlayerSprite()
    {
        int RandomSpriteIndex = Random.Range(0, playerSprite.Length);        
        spriteRenderer.sprite = playerSprite[RandomSpriteIndex];
    }
}
