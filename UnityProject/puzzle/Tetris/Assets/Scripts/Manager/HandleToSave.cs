using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UserSaveData
{
    //화이팅... 오늘의나..
    //절대 포기하지마
    //Never Give Up

    // 네임, 최고 점수...
    // 제이슨 저장하는거 흟어보고 써보고 내용변경하여 보기

    //ToDO :: 저장시킬 데이터 생각하기
    public int level;
    public int Score;
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
    //일단 형태를 만들면 변경할수있다
    //ToDo::컴포넌트와 오브젝트에 상하 관계를 잘 생각하여 테트리스 설계
    //ToDo:: 피곤하면 잠시 쉬면서 하기
    //ToDO::간단하게 시스템을 모두 만들고 그 다음에 변경
   
    //ToDo:: 옵션 데이터도 저장시키기
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
