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
        Debug.Log($"��������Ʈ ũ��{playerSprite.Length}");
        Debug.Log("�̰��� ���� ��������Ʈ �Դϴ�"+RandomSpriteIndex);
        spriteRenderer.sprite = playerSprite[RandomSpriteIndex];
    }
}
