using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyAction 
{
    DOWN,
    LEFT,
    RIGHT,
    LEFTROTATE,
    RIGHTROTATE,
    HardDrop,
    KEYCOUNT
}

//내가 적어본걸 한번 풀어보기
//플레이어 1 2 3 

//다듬는거 부터 
//키를 저장해주는 스크립트
public static class KeySetting
{ 
    public static Dictionary<KeyAction, KeyCode> keys1 = new Dictionary<KeyAction, KeyCode>();
    public static Dictionary<KeyAction, KeyCode> keys2 = new Dictionary<KeyAction, KeyCode>();

    
}
public class KeyManager
{
    private GameManager _gameManager;
    private UIManager uiManager;
    
    
    //키를 보관해주는 변수를 어떻게 선언해볼까
    //키에는 무슨 값이 있어야 될까     
    private KeyCode[] playerKeys1 = new KeyCode[] { KeyCode.S, KeyCode.A, KeyCode.D, KeyCode.Q, KeyCode.E,KeyCode.Space };
    private KeyCode[] playerKeys2 = new KeyCode[] { KeyCode.DownArrow, KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.LeftBracket, KeyCode.RightBracket,   KeyCode.RightShift };
    int key = -1;

    public void Init(GameManager gameManager)
    {
        _gameManager = gameManager;
        uiManager = gameManager.UIManager;
        
        
        //input = Input.GetKeyDown(KeyCode.W);
        //input.GetHashCode
        for (int i = 0; i < (int)KeyAction.KEYCOUNT; i++)
        {
            KeySetting.keys1.Add((KeyAction)i, playerKeys1[i]);
            KeySetting.keys2.Add((KeyAction)i, playerKeys2[i]);
        }
    }
    

    private void OnGUI()
    {
        //키보드의 이벤트가 실행되면 그 키의 값이 딕셔너리의 값으로 들어감
        Event keyEvent = Event.current;        
        
        if(keyEvent.isKey)
        {
            if(uiManager.Player1KeyOption())
            {
                KeySetting.keys1[(KeyAction)key] = keyEvent.keyCode;
                key = -1;
            }
            else if(uiManager.Player2KeyOption())
            {
                KeySetting.keys2[(KeyAction)key] = keyEvent.keyCode;
                key = -1;
            }
            
        }
    }
    
    //public void ChangeKeySetting()

    //버튼을 누르면 그 버튼의 키값을 불러오는 것
    public void ChangeKey(int num)
    {
        key = num;
    }
    
    
}
