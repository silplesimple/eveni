using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Serializable]
public class UserSaveData
{    
    //ToDO :: Ȧ�� ��

    // ����, �ְ� ����...
    // ���̽� �����ϴ°� Ł��� �Ẹ�� ���뺯���Ͽ� ����

    //ToDO :: �����ų ������ �����ϱ�
    public int level;
    public int Score;
}

[Serializable]
public class OptionSaveData
{
    public KeyCode[] KeyBoard1=new KeyCode[(int)KeyAction.KEYCOUNT];
    // ����, Ű�����ε�, �ػ�, ��Ÿ...
}

public class HandleToSave 
{
    GameManager _gameManager;

    KeyManager _keyManager;

    private string path = Path.Combine(Application.dataPath, "database.json");

    public void Init(GameManager gameManager)
    {
        _gameManager = gameManager;
        _keyManager = gameManager.KeyManager;

        if (_gameManager == null)
            Debug.LogError("GameManager if Null");
    }
    //�ϴ� ���¸� ����� �����Ҽ��ִ�
    //ToDo::������Ʈ�� ������Ʈ�� ���� ���踦 �� �����Ͽ� ��Ʈ���� ����
    //ToDo:: �ǰ��ϸ� ��� ���鼭 �ϱ�
    //ToDO::�����ϰ� �ý����� ��� ����� �� ������ ����
   
    //ToDo:: �ɼ� �����͵� �����Ű��
    public void LoadOptionData()
    {
        //���̽����� ���� ������ �״�� �ٽ� Ǯ� ��ü�� ������ �ȴ�
        OptionSaveData optionSaveData=new OptionSaveData();

        //��ο� ������ �ٽ� �����϶�
        if(!File.Exists(path))
        {
            SaveOptionData();
        }
        else
        {
            //�ؽ�Ʈ ������ �ҷ��ͼ�
            string loadJson = File.ReadAllText(path);
            //������Ʈ�� ���� ������ ��������
            optionSaveData = JsonUtility.FromJson<OptionSaveData>(loadJson);

            //������Ʈ ������ �ٽ� �ʵ忡 �ҷ��´�
            if(optionSaveData !=null)
            {
                for(int i=0;i<optionSaveData.KeyBoard1.Length;i++)
                {
                    _keyManager.SetPlayerKeyCode(1, i, optionSaveData.KeyBoard1[i]);
                }                
            }
        }
        
    }
    public void SaveOptionData()
    {
        //������ ���ϴ� ��ü�� �����
        OptionSaveData optionSaveData = new OptionSaveData();

        int a = 0;
        //��ü�ȿ� ���ӿ� ���� ������ �����Ѵ�
        for(int i=0;i<(int)KeyAction.KEYCOUNT;i++)
        {           
            optionSaveData.KeyBoard1[i] = _gameManager.KeyManager.GetPlayerKeyCode(1, i);
        }        
        
        //�� ������ string���� �ٲ۴�
        string json = JsonUtility.ToJson(optionSaveData, true);

        //��ο� ������ ��� �ؽ�Ʈ ���Ϸ� ĸ��ȭ �Ѵ�
        File.WriteAllText(path, json);
    }
    public bool SaveUserData(int stage,int score)
    {
        UserSaveData userSaveData = new UserSaveData()
        {
            level = stage,
            Score = score
            // TODO :: ���� �ʿ��� ������ ����
        };

        string json = JsonUtility.ToJson(userSaveData);

        Debug.Log(json);
        // ���Ϸ� ����
        // TODO:: ���� ���
        
        return true;
    }

    public bool LoadUserData()
    {
        // TODO:: ���� ���
        string path = "";
        UserSaveData userData = JsonUtility.FromJson<UserSaveData>(path);
        
        // TODO:: ������ ����

        
        
        return true;
    }
}
