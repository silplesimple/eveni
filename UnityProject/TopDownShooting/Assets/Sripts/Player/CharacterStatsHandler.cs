using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharacterStatsHandler : MonoBehaviour
{
    [SerializeField] private CharacterStats baseStats;
    public CharacterStats CurrentStates { get; private set; }
    public List<CharacterStats> statsModifiers = new List<CharacterStats>();
    //stat
    private const float MinAttackDelay = 0.03f;
    private const float MinAttackPower = 0.5f;
    private const float MinAttackSize = 0.4f;
    private const float MinAttackSpeed = .1f;

    private const float MinSpeed = 0.8f;

    private const int MinMaxHealth = 5;

    private void Awake()
    {        
        UpdateCharacterStats();
    }

    private void UpdateCharacterStats()
    {
        AttackSO attackSO = null;        
        if (baseStats.attackSO !=null)
        {
            attackSO = Instantiate(baseStats.attackSO);
        }        
        CurrentStates = new CharacterStats { attackSO = attackSO };
        //CurrentStates.statsChangeType = baseStats.statsChangeType;
        //CurrentStates.maxHealth = baseStats.maxHealth;
        //CurrentStates.speed = baseStats.speed;        
        UpdateStats((a, b) => b, baseStats);
        if(CurrentStates.attackSO != null) 
        {
            CurrentStates.attackSO.target = baseStats.attackSO.target;
        }

        foreach(CharacterStats modifier in statsModifiers.OrderBy(o=>o.statsChangeType))
        {
            if(modifier.statsChangeType==StatsChangeType.Override)
            {
                UpdateStats((o, o1) => 01, modifier);
            }
            else if(modifier.statsChangeType== StatsChangeType.Add)
            {
                UpdateStats((o, o1) => o + o1, modifier);
            }
            else if(modifier.statsChangeType==StatsChangeType.Multiple)
            {
                UpdateStats((o, o1) => o * o1, modifier);
            }
        }

        LimitAllStats();
    }

    private void UpdateStats(Func<float,float,float> operation,CharacterStats newModifier)
    {
        CurrentStates.maxHealth = (int)operation(CurrentStates.maxHealth, newModifier.maxHealth);
        CurrentStates.speed = operation(CurrentStates.speed, newModifier.speed);

        if (CurrentStates.attackSO == null || newModifier.attackSO == null)
        {
            return;
        }

        UpdateAttackStats(operation, CurrentStates.attackSO, newModifier.attackSO);

        if(CurrentStates.attackSO.GetType()!=newModifier.attackSO.GetType())
        {
            return;
        }

        switch(CurrentStates.attackSO)
        {
            case RangedAttackData _:
                ApplyRangedStats(operation, newModifier);
                break;
        }
    }

    private void UpdateAttackStats(Func<float,float,float> operation,AttackSO currentAttack,AttackSO newAttack)
    {
        if(currentAttack==null||newAttack==null)
        {
            return;
        }

        currentAttack.delay = operation(currentAttack.delay, newAttack.delay);
        currentAttack.power = operation(currentAttack.power, newAttack.power);
        currentAttack.size = operation(currentAttack.size, newAttack.size);
        currentAttack.speed = operation(currentAttack.speed, newAttack.speed);
    }

    private void ApplyRangedStats(Func<float,float,float> operation,CharacterStats newModifier)
    {
        RangedAttackData currentRangedAttacks = (RangedAttackData)CurrentStates.attackSO;

        if(!(newModifier.attackSO is RangedAttackData))
        {
            return;
        }

        RangedAttackData rangedAttackModifier = (RangedAttackData)newModifier.attackSO;
        currentRangedAttacks.mutipleProjectilesAngel =
            operation(currentRangedAttacks.mutipleProjectilesAngel, rangedAttackModifier.mutipleProjectilesAngel);
        currentRangedAttacks.spread = operation(currentRangedAttacks.spread, rangedAttackModifier.spread);
        currentRangedAttacks.duration = operation(currentRangedAttacks.duration, rangedAttackModifier.duration);
        currentRangedAttacks.numberofProjectPerShot = Mathf.CeilToInt(operation(currentRangedAttacks.numberofProjectPerShot, rangedAttackModifier.numberofProjectPerShot));
        currentRangedAttacks.projectileColor=UpdateColor(operation,currentRangedAttacks.projectileColor,rangedAttackModifier.projectileColor);
        
    }

    private Color UpdateColor(Func<float,float,float> operation,Color currentColor,Color newColor)
    {
        return new Color
        (
            operation(currentColor.r, newColor.r),
            operation(currentColor.g, newColor.g),
            operation(currentColor.b, newColor.b),
            operation(currentColor.a, newColor.a)
        );
        
    }

    private void LimitStats(ref float stat,float minVal)
    {
        stat = Mathf.Max(stat, minVal);
    }

    private void LimitAllStats()
    {
        if(CurrentStates==null||CurrentStates.attackSO==null)
        {
            return;
        }

        LimitStats(ref CurrentStates.attackSO.delay, MinAttackDelay);
        LimitStats(ref CurrentStates.attackSO.power, MinAttackPower);
        LimitStats(ref CurrentStates.attackSO.size, MinAttackSize);
        LimitStats(ref CurrentStates.attackSO.speed, MinAttackSpeed);
        LimitStats(ref CurrentStates.speed, MinSpeed);
        CurrentStates.maxHealth = Mathf.Max(CurrentStates.maxHealth, MinMaxHealth);
    }
    public void AddStatModifier(CharacterStats statModifier)
    {
        statsModifiers.Add(statModifier);
        UpdateCharacterStats();
    }

    public void RemoveStatModifier(CharacterStats statModifier)
    {
        statsModifiers.Remove(statModifier);
        UpdateCharacterStats();
    }


}
