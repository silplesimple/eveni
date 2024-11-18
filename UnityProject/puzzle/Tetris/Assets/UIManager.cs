using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField]
    TextMeshProUGUI scoreText;
    int score;
    
    //점수 추가
    public void PlusScore(int stageScore)
    {
        score += stageScore;
        scoreText.text = score.ToString();
    }

    protected override void Awake()
    {
        base.Awake();
        Debug.Log("야호");
    }


}
