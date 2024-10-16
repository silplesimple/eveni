using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private float healthChangeDelay = 0.5f;

    private CharacterStatsHandler statsHandler;
    private float timeSinceLastChange = float.MaxValue;

    public event Action OnDamage;
    public event Action OnHeal;
    public event Action OnDeath;
    public event Action OnInvincibilityEnd;

    public float CurrentHealth { get; private set; }

    public float MaxHealth => statsHandler.CurrentStates.maxHealth;

    private void Awake()
    {
        statsHandler = GetComponent<CharacterStatsHandler>();
    }

    private void Start()
    {
        CurrentHealth = statsHandler.CurrentStates.maxHealth;
    }

    private void Update()
    {
        if(timeSinceLastChange < healthChangeDelay)
        {
            timeSinceLastChange += Time.deltaTime;
            if(timeSinceLastChange>=healthChangeDelay)
            {
                OnInvincibilityEnd.Invoke();
            }
        }
    }

    public bool ChangeHealth(float change)
    {
        if(change==0||timeSinceLastChange<healthChangeDelay)
        {
            return false;
        }

        timeSinceLastChange = 0f;
        CurrentHealth += change;
        CurrentHealth = CurrentHealth > MaxHealth ? MaxHealth : CurrentHealth;
        CurrentHealth = CurrentHealth < 0 ? 0 : CurrentHealth;

        if(change>0)
        {
            OnHeal?.Invoke();
        }
        else
        {
            OnDamage?.Invoke();
        }

        if (CurrentHealth <= 0f)
        {
            CallDeath();
        }

        return true;
    }

    private void CallDeath()
    {
        OnDeath?.Invoke();
    }
}
