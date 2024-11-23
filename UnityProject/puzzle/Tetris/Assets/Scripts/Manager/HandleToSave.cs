using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UserSaveData
{
    // 네임, 최고 점수...
}

[Serializable]
public class OptionSaveData
{
    // 사운드, 키리바인딩, 해상도, 기타...
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
            // TODO :: 저장 필요한 데이터 정리
        };

        string json = JsonUtility.ToJson(userSaveData);
        
        // 파일로 저장
        // TODO:: 저장 경로
        
        return true;
    }

    public bool LoadUserData()
    {
        // TODO:: 저장 경로
        string path = "";
        UserSaveData userData = JsonUtility.FromJson<UserSaveData>(path);
        
        // TODO:: 데이터 적용

        
        
        return true;
    }
}
