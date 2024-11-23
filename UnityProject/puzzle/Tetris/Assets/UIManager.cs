using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    [SerializeField]
    TextMeshProUGUI scoreText;    
    public TextMeshProUGUI[] player1Text;
    public TextMeshProUGUI[] player2Text;
    int score;
    [SerializeField]
    private GameObject player1Panel;
    [SerializeField]
    private GameObject player2Panel;
    [SerializeField]
    private GameObject Option;
    
    
    
    //���� �߰�
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
        SetKeyBoard();
    }
    
    private void Update()
    {
        if (Player1KeyOption() || Player2KeyOption())
        {
            SetKeyBoard();
        }

    }

    private void SetKeyBoard()
    {        
        for (int i = 0; i < player1Text.Length; i++)
        {
            player1Text[i].text = KeySetting.keys1[(KeyAction)i].ToString();
            player2Text[i].text = KeySetting.keys2[(KeyAction)i].ToString();
        }
    }
    public bool Player1KeyOption()
    {        
        return player1Panel.activeSelf;
    }

    public bool Player2KeyOption()
    {
        return player2Panel.activeSelf;
    }

    public bool isOptionActive()
    {
        return Option.activeSelf ;
    }

}
