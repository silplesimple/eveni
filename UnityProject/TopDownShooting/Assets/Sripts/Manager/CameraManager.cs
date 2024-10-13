using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : Singleton<CameraManager>
{
    //카메라를 초기화 해서 카메라의 값을 다른데서 사용할수 있게
    private Camera camera;

    private void Awake()
    {
        this.DontDestroySingleton(this);         
    }
    private void Start()
    {
        camera = Camera.main;
    }

    public CameraManager initialize()
    {
        return CameraManager.Instance;
    }
    //카메라의 기능
    public Vector2 CameraWorldPoint(Vector2 inputValue)
    {
        return camera.ScreenToWorldPoint(inputValue);
    }
}
