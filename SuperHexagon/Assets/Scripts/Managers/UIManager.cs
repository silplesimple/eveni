using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    Player player;
    private void Awake()
    {
        player =FindObjectOfType<Player>();
    }
    private void Start()
    {
        player.OnDeath += GameOver;
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    private void GameOver()
    {
        Debug.Log("이벤트 호출");
    }
    
}
