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

    private Vector2 knockback = Vector2.zero;
    private float knockbackDuration = 0.0f;

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
        if(knockbackDuration>0.0f)
        {
            knockbackDuration -= Time.deltaTime;
        }
    }
    public void ApplyKnockback(Transform other,float power,float duration)
    {
        knockbackDuration = duration;
        knockback = -(other.position - transform.position).normalized*power;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * stats.CurrentStates.speed;
        if(knockbackDuration>0.0f)
        {
            direction += knockback;
        }
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
