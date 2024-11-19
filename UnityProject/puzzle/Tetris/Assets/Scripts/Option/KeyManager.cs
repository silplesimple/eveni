using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyAction {DOWN,LEFT,RIGHT,LEFTROTATE,RIGHTROTATE,HardDrop,KEYCOUNT}
//Ű�� �������ִ� ��ũ��Ʈ

public static class KeySetting { public static Dictionary<KeyAction, KeyCode> keys = new Dictionary<KeyAction, KeyCode>(); }
public class KeyManager: Singleton<KeyManager>
{

    //Ű�� �������ִ� ������ ��� �����غ���
    //Ű���� ���� ���� �־�� �ɱ� 
    Input input;
    KeyCode[] defaultKeys = new KeyCode[] { KeyCode.S, KeyCode.A, KeyCode.D, KeyCode.Q, KeyCode.E,KeyCode.Space };

    int key = -1;
    //�����ؾ��ϴ� Ű qweasd �� Ű ������ �� �����ؾߴ�
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
        string me = "�ɼ���";
        string text = "��û�ϴ�";
        Debug.Log(me + text);
    }

    //���⿡�� �����س��� Ű �ڵ带 ����
    //���� �س����� �ٸ� �Լ����� ����Ҽ��ְ� ������
    //�׸��� �س����� �����ε� ��ɵ� �� Ű�ڵ忡�� �ٲܼ��ְ�
    //public KeyCode InputKey()
    //{
    //    //�̹� ������� ���� Ű �ڵ忡 Ű ���� ����
    //    //keyCode = KeyCode.Q;//�� Ű�ڵ� �ϰ� �ٸ� Ű �ڵ带 �ٲٴ� ���� �ٲ㼭 �������ְ�
    //    ////Ű ���� ����
    //    //Debug.Log("���ο� Ű�ڵ�"+keyCode);
    //    //return keyCode;
    //}

    //���ο� Ű�� �Է� �޾� �װ� ��ųʸ��� ����Ǿ��ִ� Ű ���ӿ� Ű�ڵ�� ���� �س��� ����//�̰� ���ݸ� �� �����غ���
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
    
    //���⼭ Ű ������ �ؼ� Ű �����Ѱɷ� 
    public void ChangeKey(int num)
    {
        key = num;
    }
    public void UpKey()
    {
        
    }
}
