using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyAction {DOWN,LEFT,RIGHT,LEFTROTATE,RIGHTROTATE,HardDrop,KEYCOUNT}
//키를 저장해주는 스크립트

public static class KeySetting { public static Dictionary<KeyAction, KeyCode> keys = new Dictionary<KeyAction, KeyCode>(); }
public class KeyManager: Singleton<KeyManager>
{

    //키를 보관해주는 변수를 어떻게 선언해볼까
    //키에는 무슨 값이 있어야 될까 
    Input input;
    KeyCode[] defaultKeys = new KeyCode[] { KeyCode.S, KeyCode.A, KeyCode.D, KeyCode.Q, KeyCode.E,KeyCode.Space };

    int key = -1;
    //저장해야하는 키 qweasd 이 키 값들을 다 저장해야댐
    //

    protected override void Awake()
    {
        base.Awake();
        //input = Input.GetKeyDown(KeyCode.W);
        //input.GetHashCode
        for (int i = 0; i < (int)KeyAction.KEYCOUNT; i++)
        {
            KeySetting.keys.Add((KeyAction)i, defaultKeys[i]);
        }
    }
    private void Start()
    {
        
    }
    private void Stupit()
    {
        string me = "심선규";
        string text = "멍청하다";
        Debug.Log(me + text);
    }

    //여기에서 저장해놓은 키 코드를 저장
    //저장 해놓은걸 다른 함수에서 사용할수있게 보내기
    //그리고 해놓으면 리바인딩 기능도 이 키코드에서 바꿀수있게
    //public KeyCode InputKey()
    //{
    //    //이미 만들어진 변수 키 코드에 키 값을 저장
    //    //keyCode = KeyCode.Q;//이 키코드 하고 다른 키 코드를 바꾸는 값을 바꿔서 보낼수있게
    //    ////키 값을 리턴
    //    //Debug.Log("새로운 키코드"+keyCode);
    //    //return keyCode;
    //}

    //새로운 키를 입력 받아 그걸 딕셔너리에 저장되어있는 키 네임에 키코드로 저장 해놓은 다음//이건 조금만 더 생각해보자
    public void SetKeyCode(string keyName,KeyCode keycode)
    {

    }

    private void OnGUI()
    {
        Event keyEvent = Event.current;
        if(keyEvent.isKey)
        {
            KeySetting.keys[(KeyAction)key] = keyEvent.keyCode;
            key = -1;
        }
    }
    
    //여기서 키 변경을 해서 키 변경한걸로 
    public void ChangeKey(int num)
    {
        key = num;
    }
    public void UpKey()
    {
        
    }
}
