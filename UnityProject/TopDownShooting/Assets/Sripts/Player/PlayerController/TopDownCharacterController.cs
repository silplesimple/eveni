using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action<AttackSO> OnAttackEvent;

    private AttackSO SetAttackSO;

    private float timeSinceLastAttack = float.MaxValue;
    protected bool IsAttacking { get; set; }
    protected CharacterStatsHandler Stats { get; private set; }

    protected virtual void Awake()
    {
        Stats = GetComponent<CharacterStatsHandler>();        
    }

    protected virtual void Update()
    {
        HandleAttackDelay();
    }

    private void HandleAttackDelay()
    {
        SetAttackSO = Stats.CurrentStates.attackSO;
        if (SetAttackSO == null)
        {
            return;                
        }

        if(timeSinceLastAttack<= SetAttackSO.delay)
        {
            timeSinceLastAttack += Time.deltaTime;
        }

        if(IsAttacking && timeSinceLastAttack> SetAttackSO.delay)
        {            
            timeSinceLastAttack = 0;
            CallAttackEvent(SetAttackSO);
        }
    }
    
   
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    public void CallAttackEvent(AttackSO attackSO)
    {
        OnAttackEvent?.Invoke(attackSO);
    }

    
}
