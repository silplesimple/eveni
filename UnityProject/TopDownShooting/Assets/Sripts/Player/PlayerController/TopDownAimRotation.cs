using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform armPivot;
    [SerializeField] private SpriteRenderer CharacterRenderer;

    
    private TopDownCharacterController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownCharacterController>();        
    }
    
    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotz = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;        

        bool onFlipX = Mathf.Abs(rotz) > 90f;
        //armRenderer.flipX = onFlipX;
        CharacterRenderer.flipX = onFlipX;
        armPivot.rotation = Quaternion.Euler(0, 0, rotz);
    }

    public Quaternion GetArmRotation()
    {
        return armPivot.rotation;
    }
}
