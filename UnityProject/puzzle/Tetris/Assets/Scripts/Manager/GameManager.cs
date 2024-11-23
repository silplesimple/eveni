using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public KeyManager KeyManager { get; private set; }
    public UIManager UIManager { get; private set; }
    public HandleToSave HandleToSave { get; private set; }
    protected override void Awake()
    {
        base.Awake();

        KeyManager = new KeyManager();
        UIManager = FindObjectOfType<UIManager>();
        HandleToSave = new HandleToSave();
        
        KeyManager.Init(this);
        UIManager.Init(this);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
