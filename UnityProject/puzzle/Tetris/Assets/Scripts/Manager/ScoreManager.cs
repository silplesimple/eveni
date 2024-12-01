using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum standardScore
{
    SoftDrop=1,
    HardDrop=2,
    Single=100,
    Double=300,
    Triple=500,
    Tetris=800,
    MiniTSpin=100,
    MiniTSpinSingle=200,
    TSpin=100,
    TSpinDouble=1200,
    TSpinTriple=1600,
    SingleAllClear=800,
    DoubleAllClear=1200,
    TripleAllClear=1800,
    TetrisAllClear=2000,
    BackToBackAllClear=3200,
}

//ToDO 클래스를 만들어서 점수를 관리?
public class ScoreManager : MonoBehaviour
{
    private GameManager _gameManager;
    private int score = 3;
    public int ClearCount = 0;

    public void Init(GameManager gameManager)
    {
        _gameManager = gameManager;
    }

    public int NowScore()
    {
        return score;
    }
}
