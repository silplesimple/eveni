using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : Singleton<CameraManager>
{
    //ī�޶� �ʱ�ȭ �ؼ� ī�޶��� ���� �ٸ����� ����Ҽ� �ְ�
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
    //ī�޶��� ���
    public Vector2 CameraWorldPoint(Vector2 inputValue)
    {
        return camera.ScreenToWorldPoint(inputValue);
    }
}
