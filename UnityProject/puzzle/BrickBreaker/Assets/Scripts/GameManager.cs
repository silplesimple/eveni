using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Ball ball { get; private set; }
    public Paddle paddle { get; private set; }
    public Brick[] Bricks { get; private set; }

    public int level = 1;
    public int score = 0;
    public int lives = 3;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        SceneManager.sceneLoaded += OnLevelLoaded;
    }

    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        this.score = 0;
        this.lives = 3;

        LoadLevel(1);
    }

    private void LoadLevel(int level)
    {
        this.level = level;

        if(level>10)
        {
            SceneManager.LoadScene("WinScreen");
        }
        else
        {
            SceneManager.LoadScene("Level" + level);
        }

        SceneManager.LoadScene("Level"+level);
    }

    private void OnLevelLoaded(Scene scene,LoadSceneMode mode)
    {
        this.ball = FindObjectOfType<Ball>();
        this.paddle = FindObjectOfType<Paddle>();
        this.Bricks = FindObjectsOfType<Brick>();
    }
    private void ResetLevel()
    {
        this.ball.ResetBall();
        this.paddle.ResetPaddle();

        //for(int i=0;i<this.Bricks.Length;i++)
        //{
        //    this.Bricks[i].ResetBrick();
        //}
    }

    private void GameOver()
    {
        //SceneManager.LoadScene("GameOver");

        NewGame();
    }
    public void Miss()
    {
        this.lives--;

        if (this.lives > 0)
        {
            ResetLevel();
        }
        else
        {
            GameOver();
        }
    }
    public void Hit(Brick brick)
    {
        this.score += brick.points;

        if(Cleared())
        {
            LoadLevel(this.level + 1);
        }
    }

    private bool Cleared()
    {
        for(int i=0;i<this.Bricks.Length;i++)
        {
            if (this.Bricks[i] .gameObject.activeInHierarchy && !this.Bricks[i].unbreakable)
            {
                return false;
            }
        }

        return true;
    }
}
