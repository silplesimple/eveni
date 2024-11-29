using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public KeyManager KeyManager { get; private set; }
    public UIManager UIManager { get; private set; }
    public HandleToSave HandleToSave { get; private set; }
    
    public ScoreManager ScoreManager { get; private set; }
    private int Stage;
    //TODO:: 스테이지 관리 시스템

    //TODO::점수 관리 시스템

    
    protected override void Awake()
    {
        base.Awake();

        KeyManager = new KeyManager();
        UIManager = FindObjectOfType<UIManager>();
        HandleToSave = new HandleToSave();
        ScoreManager= new ScoreManager();
        
        KeyManager.Init(this);
        UIManager.Init(this);
        ScoreManager.Init(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //임시 시점
        HandleToSave.SaveUserData(3, ScoreManager.NowScore());
    }
}
