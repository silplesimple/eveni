using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController controller;
    private CharacterStatsHandler stats;

    private Vector2 movementDirection = Vector2.zero;
    private Rigidbody2D rigidbody;

    private void Awake()
    {
        controller = GetComponent<TopDownCharacterController>();
        stats = GetComponent<CharacterStatsHandler>();
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
        direction = direction * stats.CurrentStates.speed;
        rigidbody.velocity = direction;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void MoveAttack(Vector2 direction)        
    {
        Debug.Log("�̵��ϸ鼭 �ϴ� �����̴�!");
    }

}
