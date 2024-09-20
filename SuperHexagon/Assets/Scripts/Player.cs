using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer spriteRenderer;
    [SerializeField]
    Sprite[] playerSprite;
    [SerializeField]
    Vector3 playerPos;
    //float
    [SerializeField]
    PlayerMove playerMove;

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
        if(Input.GetAxis("Horizontal")!=0)
        {
            playerMove.Move(playerPos);
        }
    }
    private void SetPlayerSprite()
    {
        int RandomSpriteIndex = Random.Range(0, playerSprite.Length);        
        spriteRenderer.sprite = playerSprite[RandomSpriteIndex];
    }
}
