using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer spriteRenderer;
    [SerializeField]
    Sprite[] playerSprite;

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }
    private void Start()
    {
        SetPlayerSprite(); 
    }
    
    private void SetPlayerSprite()
    {
        int RandomSpriteIndex = Random.Range(0, playerSprite.Length);
        Debug.Log($"스프라이트 크기{playerSprite.Length}");
        Debug.Log("이것은 랜덤 스프라이트 입니다"+RandomSpriteIndex);
        spriteRenderer.sprite = playerSprite[RandomSpriteIndex];
    }
}
