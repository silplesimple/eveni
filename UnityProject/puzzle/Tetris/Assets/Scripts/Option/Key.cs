using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//키를 저장해주는 스크립트
public class KeyManager: Singleton<KeyManager>
{
    //키를 보관해주는 변수를 어떻게 선언해볼까
    Input input;

    private void Awake()
    {
        //input = Input.GetKeyDown(KeyCode.W);
        //input.GetHashCode
    }
    
    public void UpKey()
    {
        
    }
}
