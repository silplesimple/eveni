using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    [SerializeField]
    TextMeshProUGUI scoreText;    
    public TextMeshProUGUI[] keyBoardText;
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
    }

    private void Start()
    {
        for(int i=0;i<keyBoardText.Length;i++)
        {
            keyBoardText[i].text = KeySetting.keys[(KeyAction)i].ToString();
        }
    }

    private void Update()
    {
        for (int i = 0; i < keyBoardText.Length; i++)
        {
            keyBoardText[i].text = KeySetting.keys[(KeyAction)i].ToString();
        }
    }

}
