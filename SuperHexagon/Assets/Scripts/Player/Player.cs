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
        moveInput = Input.GetAxisRaw("Horizontal")*playerSpeed*Time.deltaTime;       
        if(moveInput!=0)
        {
            playerMove.Move(playerMoveObj,moveInput);
        }
        //Debug.Log()
    }
    //�÷��̾� ��������Ʈ ����
    private void SetPlayerSprite()
    {
        int RandomSpriteIndex = Random.Range(0, playerSprite.Length);        
        spriteRenderer.sprite = playerSprite[RandomSpriteIndex];
    }
}
