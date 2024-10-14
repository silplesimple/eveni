using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController controller;

    private Vector2 movementDirection = Vector2.zero;
    private Rigidbody2D rigidbody;

    private void Awake()
    {
        controller = GetComponent<TopDownCharacterController>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
        controller.OnMoveEvent += MoveAttack;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        rigidbody.velocity = direction;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void MoveAttack(Vector2 direction)        
    {
        Debug.Log("이동하면서 하는 공격이닷!");
    }

}
