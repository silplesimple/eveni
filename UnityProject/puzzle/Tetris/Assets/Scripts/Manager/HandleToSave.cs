using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UserSaveData
{
    // ����, �ְ� ����...
}

[Serializable]
public class OptionSaveData
{
    // ����, Ű�����ε�, �ػ�, ��Ÿ...
}

public class HandleToSave 
{
    GameManager _gameManager;

    public void Init(GameManager gameManager)
    {
        _gameManager = gameManager;
    }
    
    public bool SaveUserData()
    {
        UserSaveData userSaveData = new UserSaveData()
        {
            // TODO :: ���� �ʿ��� ������ ����
        };

        string json = JsonUtility.ToJson(userSaveData);
        
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
