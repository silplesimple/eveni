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

//���� ����� �ѹ� Ǯ���
//�÷��̾� 1 2 3 

//�ٵ�°� ���� 
//Ű�� �������ִ� ��ũ��Ʈ
public static class KeySetting
{ 
    public static Dictionary<KeyAction, KeyCode> keys1 = new Dictionary<KeyAction, KeyCode>();
    public static Dictionary<KeyAction, KeyCode> keys2 = new Dictionary<KeyAction, KeyCode>();

    
}
public class KeyManager
{
    private GameManager _gameManager; 
    private UIManager uiManager;
    
    
    //Ű�� �������ִ� ������ ��� �����غ���
    //Ű���� ���� ���� �־�� �ɱ�     
    private KeyCode[] playerKeys1 = new KeyCode[] { KeyCode.S, KeyCode.A, KeyCode.D, KeyCode.Q, KeyCode.E,KeyCode.Space };
    private KeyCode[] playerKeys2 = new KeyCode[] { KeyCode.DownArrow, KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.LeftBracket, KeyCode.RightBracket,   KeyCode.RightShift };
    private int key = -1;

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
    
    //�̰� �ѹ� �����鼭 �ٸ��ŷ� �����غ���
    private void OnGUI()
    {
        //Ű������ �̺�Ʈ�� ����Ǹ� �� Ű�� ���� ��ųʸ��� ������ ��
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

    //��ư�� ������ �� ��ư�� Ű���� �ҷ����� ��
    //�̱���� OnGUI�� ���� �����ʰ� 
    //�����غ���
    //�� ����� ��ư�� ������ �� ��ư�� Ű���� �´� ��ųʸ��� Ű�ڵ带 �޾� �� Ű�ڵ带 ��ųʸ��� ������ �ִ°� 
    //�׷��� ����� �ٲܼ� �ִ� ������ �ִ�.
    public void ChangeKey(int num)
    {
        key = num;
    }
    
    
}
