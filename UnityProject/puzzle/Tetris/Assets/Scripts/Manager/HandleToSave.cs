using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UserSaveData
{
    //ȭ����... �����ǳ�..
    //���� ����������
    //Never Give Up

    // ����, �ְ� ����...
    // ���̽� �����ϴ°� Ł��� �Ẹ�� ���뺯���Ͽ� ����

    //ToDO :: �����ų ������ �����ϱ�
    public int level;
    public int Score;
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
    //�ϴ� ���¸� ����� �����Ҽ��ִ�
    //ToDo::������Ʈ�� ������Ʈ�� ���� ���踦 �� �����Ͽ� ��Ʈ���� ����
    //ToDo:: �ǰ��ϸ� ��� ���鼭 �ϱ�
    //ToDO::�����ϰ� �ý����� ��� ����� �� ������ ����
   
    //ToDo:: �ɼ� �����͵� �����Ű��
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
