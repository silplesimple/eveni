using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownContactEnemyAttack : MonoBehaviour
{
    private TopDownCharacterController controller;
    public AudioClip attackClip;
    private CharacterStatsHandler characterStatsHandler;

    private void Awake()
    {
        controller = GetComponent<TopDownCharacterController>();
        characterStatsHandler=GetComponent<CharacterStatsHandler>();
    }

    private void Start()
    {
                
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        HealthSystem playerHealth=other.GetComponent<HealthSystem>();
        AttackSO enemySO= characterStatsHandler.CurrentStates.attackSO;
        if (playerHealth != null ) 
        { 
            playerHealth.ChangeHealth(-enemySO.power);

            if(enemySO.isOnKnockback)
            {
                TopDownMovement movement=other.GetComponent<TopDownMovement>();
                if (movement != null)
                {
                    movement.ApplyKnockback(transform, enemySO.knockbackPower, enemySO.knockbackTime);
                }
            }
        }
    } 


}
