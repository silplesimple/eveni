using Completed;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Player : MovingObject
{
    public int wallDamage = 1;
    public int pointPerFood = 10;
    public int pointPerSoda = 20;
    public float restartLevelDelay = 1f;
    public Text foodText;
    public AudioClip moveSound1;
    public AudioClip moveSound2;
    public AudioClip eatSound1;
    public AudioClip eatSound2;
    public AudioClip drinkSound1;
    public AudioClip drinkSound2;
    public AudioClip gameOverSound;

    private Animator animator;
    private int food;
    private Vector2 touchOrigin = -Vector2.one;

    SoundManager soundManager;
    GameManager gameManager;

    protected override void Start()
    {
        animator = GetComponent<Animator>();
        soundManager = SoundManager.instance;
        gameManager = GameManager.instance;

        food = gameManager.playerFoodPoints;

        FoodUpdate(0);
        base.Start();
    }

    private void Update()
    {
        if (!gameManager.playersTurn) return;

        int horizontal = 0;
        int vertical = 0;

#if UNITY_STANDALONE || UNITY_WEBPLAYER

        horizontal = (int)Input.GetAxisRaw("Horizontal");
        vertical = (int)Input.GetAxisRaw("Vertical");

        if(horizontal !=0)
        {
            vertical = 0;
        }

#else
        if(Input.touchCount>0)
        {
            Touch myTouch = Input.touches[0];

            if(myTouch.phase==TouchPhase.Began)
            {
                touchOrigin = myTouch.position;
            }
            else if(myTouch.phase==TouchPhase.Ended&&touchOrigin.x>=0)
            {
                Vector2 touchEnd = myTouch.position;
                float x = touchEnd.x - touchOrigin.x;
                float y = touchEnd.y - touchOrigin.y;
                touchOrigin.x = -1;
                if(Mathf.Abs(x)>Mathf.Abs(y))
                {
                    horizontal = x > 0 ? 1 : -1;
                }
                else
                {
                    vertical = y > 0 ? 1 : -1;
                }
            }
        }
#endif
        if(horizontal!=0||vertical!=0)
        {
            AttemptMove<Wall>(horizontal, vertical);
        }

    }
    private void OnDisable()
    {
        gameManager.playerFoodPoints = food;
    }

    protected override void OnCantMove<T>(T Component)
    {
        Wall hitWall = Component as Wall;
        hitWall.DamageWall(wallDamage);
        TriggerAnimation("playerChop");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Exit")
        {
            Invoke("Restart", restartLevelDelay);
            enabled = false;
        }
        else if(other.tag=="Food")
        {
            FoodUpdate(pointPerFood);
            soundManager.RandomizeSfx(eatSound1, eatSound2);
            other.gameObject.SetActive(false);
        }
        else if(other.tag=="Soda")
        {
            FoodUpdate(pointPerSoda);
            soundManager.RandomizeSfx(eatSound1, eatSound2);
            other.gameObject.SetActive(false);
        }
    }
    private void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void LoseFood(int loss)
    {
        TriggerAnimation("playerHit");
        FoodUpdate(-loss);
    }

    private void TriggerAnimation(string parameter)
    {
        animator.SetTrigger(parameter);
    }

    protected override void AttemptMove<T>(int xDir,int yDir)
    {
        FoodUpdate();

        base.AttemptMove<T>(xDir, yDir);

        RaycastHit2D hit;
        if(Move(xDir,yDir,out hit))
        {
            soundManager.RandomizeSfx(moveSound1, moveSound2);
        }

        gameManager.ChangePlayerTurn(false);
    }
    private void CheckIfGameOver()
    {
        if(food<=0)
        {
            soundManager.PlayerSingle(gameOverSound);
            soundManager.musicSource.Stop();
            gameManager.GameOver();
        }
    }

    void FoodUpdate(int value = -1)
    {
        food += value;
        if (value == -1 || value == 0)
        {
            foodText.text = "Food: " + food;
        }
        else if (value < -1)
        {
            foodText.text = "-" + value + " Food: " + food;
        }
        else
        {
            foodText.text = "+" + value + " Food:" + food;
            return;
        }

        CheckIfGameOver();
    }

}
