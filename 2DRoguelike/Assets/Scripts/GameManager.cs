using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float levelStartDelay = 2f;
    public float turnDelay = .1f;
    public static GameManager instance = null;
    public BoardManager boardScript;
    public int playerFoodPoints = 100;
    [HideInInspector] public bool playersTurn = true;

    private Text levelText;
    private GameObject levelmage;
    private int level = 1;
    private List<Enemy> enemies;
    private bool enemiesMoving;
    private bool doingSetup;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance!=this)
        {
            Destroy(instance);
        }
        DontDestroyOnLoad(gameObject);
        enemies = new List<Enemy>();
        boardScript = GetComponent<BoardManager>();
        InitGame();
    }

    private void OnLevelWasLoaded(int index)
    {
        level++;
        InitGame();
    }
    private void InitGame()
    {
        doingSetup = true;
        levelmage = GameObject.Find("LevelImage");
        levelText = GameObject.Find("LevelText").GetComponent<Text>();
        levelText.text = "Day " + level;
        levelmage.SetActive(true);
        Invoke("HideLevelImage", levelStartDelay);

        enemies.Clear();
        boardScript.SetupScene(level);
    }

    private void HideLevelImage()
    {
        levelmage.SetActive(false);
        doingSetup = false;
    }
    public void GameOver()
    {
        levelText.text = "After" + level + " days,you starved";
        levelmage.SetActive(true);
        enabled = false;
    }

    private void Update()
    {
        if(playersTurn||enemiesMoving||doingSetup)
        {
            return;
        }
        StartCoroutine(MoveEnemies());
        
    }
    public void AddEnemyToList(Enemy script)
    {
        enemies.Add(script);
    }
    IEnumerator MoveEnemies()
    {
        enemiesMoving = true;
        yield return new WaitForSeconds(turnDelay);
        if(enemies.Count==0)
        {
            yield return new WaitForSeconds(turnDelay);
        }

        for(int i=0;i<enemies.Count;i++)
        {            
            enemies[i].MoveEnemy();
            yield return new WaitForSeconds(enemies[i].moveTime);
        }

        ChangePlayerTurn();
        enemiesMoving = false;
        Debug.Log(playersTurn);
    }

    public void ChangePlayerTurn(bool turn = true)
    {
        if(playersTurn == turn) { Debug.Log("Error"); }

        playersTurn = turn;
    }
}
