using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalPoint;
    public int stagePoint;
    public int stageIndex;
    public int health;
    public PlayerMove player;
    public GameObject[] Stages;

    public void NextStage()
    {
        //Change Stage;
        if (stageIndex < Stages.Length-1)
        {
            Stages[stageIndex].SetActive(false);
            stageIndex++;
            Stages[stageIndex].SetActive(true);
            PlayerReposition();
        }
        else
        {
            Time.timeScale = 0;
            Debug.Log("게임클리어");
        }
        totalPoint += stagePoint;
        stagePoint = 0;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMove playerMove = collision.GetComponent<PlayerMove>();
        if (playerMove != null)
        // if (collision.gameObject.tag =="Player")
        {
            //Player Reposition
            if (health > 1)
            {
                PlayerReposition();
            }
            //Health Down
            HealthDown();
        }    
    }
    void PlayerReposition()
    {
        player.transform.position = new Vector3(-6, 1.5f, -1);
        player.VelocityZero();
    }
    public void HealthDown()
    {
        if(health>1)
        {
            health--;
        }
        else
        {
            player.OnDie();

            Debug.Log("죽었습니다앙");
        }
    }
}
