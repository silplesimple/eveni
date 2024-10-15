using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public Transform player { get; private set; }
    [SerializeField] private string playerTag = "Player";


    private void Awake()
    {
        DontDestroySingleton(this);
        player = GameObject.FindGameObjectWithTag(playerTag).transform;
        if (player != null)
        {
            Debug.Log("플레이어 안비었다!!!");
        }
    }
    
}
