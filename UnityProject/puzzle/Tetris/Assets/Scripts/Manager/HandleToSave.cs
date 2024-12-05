using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Serializable]
public class UserSaveData
{    
    //ToDO :: 홀리 쉿

    // 네임, 최고 점수...
    // 제이슨 저장하는거 흟어보고 써보고 내용변경하여 보기

    //ToDO :: 저장시킬 데이터 생각하기
    public int level;
    public int Score;
}

[Serializable]
public class OptionSaveData
{
    public KeyCode[] KeyBoard1=new KeyCode[(int)KeyAction.KEYCOUNT];
    // 사운드, 키리바인딩, 해상도, 기타...
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
    //일단 형태를 만들면 변경할수있다
    //ToDo::컴포넌트와 오브젝트에 상하 관계를 잘 생각하여 테트리스 설계
    //ToDo:: 피곤하면 잠시 쉬면서 하기
    //ToDO::간단하게 시스템을 모두 만들고 그 다음에 변경
   
    //ToDo:: 옵션 데이터도 저장시키기
    public void LoadOptionData()
    {
        //제이슨에서 묶은 내용을 그대로 다시 풀어서 객체에 담으면 된다
        OptionSaveData optionSaveData=new OptionSaveData();

        //경로에 없으면 다시 저장하라
        if(!File.Exists(path))
        {
            SaveOptionData();
        }
        else
        {
            //텍스트 파일을 불러와서
            string loadJson = File.ReadAllText(path);
            //오브젝트에 파일 정보를 가져오고
            optionSaveData = JsonUtility.FromJson<OptionSaveData>(loadJson);

            //오브젝트 정보를 다시 필드에 불러온다
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
        //저장을 원하는 객체를 만든다
        OptionSaveData optionSaveData = new OptionSaveData();

        int a = 0;
        //객체안에 게임에 대한 내용을 저장한다
        for(int i=0;i<(int)KeyAction.KEYCOUNT;i++)
        {           
            optionSaveData.KeyBoard1[i] = _gameManager.KeyManager.GetPlayerKeyCode(1, i);
        }        
        
        //그 내용을 string으로 바꾼다
        string json = JsonUtility.ToJson(optionSaveData, true);

        //경로와 내용을 담아 텍스트 파일로 캡슐화 한다
        File.WriteAllText(path, json);
    }
    public bool SaveUserData(int stage,int score)
    {
        UserSaveData userSaveData = new UserSaveData()
        {
            level = stage,
            Score = score
            // TODO :: 저장 필요한 데이터 정리
        };

        string json = JsonUtility.ToJson(userSaveData);

        Debug.Log(json);
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
