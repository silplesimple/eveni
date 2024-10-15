using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private CameraManager cameraManager;    
    
    protected override void Awake()
    {
        base.Awake();
       cameraManager=CameraManager.Instance.initialize();
    }


    public void OnMove(InputValue value)
    {
        //Vector2 debugVector2= value.Get<Vector2>().normalized;
        //Debug.Log(debugVector2);
        //Debug.Log("���� �̺�Ʈ ������!");
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }
    
    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        //Debug.Log("�̺�Ʈ ����!!"+newAim);
        Vector2 worldPos=cameraManager.CameraWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if(newAim.magnitude>=.9f)
        {
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {
        //Debug.Log("���� ���� �۵�");
        IsAttacking=value.isPressed;
    }
}
