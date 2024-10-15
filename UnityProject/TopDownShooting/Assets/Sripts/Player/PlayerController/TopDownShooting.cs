using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using static UnityEngine.Random;


public class TopDownShooting : MonoBehaviour
{

    [SerializeField] private Transform projectileSpawnPosition;
    private Vector2 aimDirection = Vector2.right;
    //private ProjectileManager
    private ProjectileManager projectileManager;

    private TopDownCharacterController controller;
    private TopDownAimRotation aim;
    private void Awake()
    {
        projectileManager = ProjectileManager.Instance;
        aim= GetComponent<TopDownAimRotation>();    
        controller = GetComponent<TopDownCharacterController>();        
    }

    private void Start()
    {
        controller.OnAttackEvent += OnShoot;
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        aimDirection = newAimDirection;
    }

    private void OnShoot(AttackSO attackSO)
    {
        Debug.Log("½´ÆÃ¹ÙÄí°£");
        RangedAttackData rangedAttackData = attackSO as RangedAttackData;
        float projectileAngleSpace = rangedAttackData.mutipleProjectilesAngel;
        int numberOfProjectilePerShot = rangedAttackData.numberofProjectPerShot;

        float minAngle = -(numberOfProjectilePerShot / 2f)
            * projectileAngleSpace + 0.5f 
            * rangedAttackData.mutipleProjectilesAngel;

        for(int i=0;i<numberOfProjectilePerShot;i++)
        {
            float angle = minAngle + projectileAngleSpace * i;
            float randomSpread = Range(-rangedAttackData.spread, 
                rangedAttackData.spread);
            angle += randomSpread;
            CreateProjectile(rangedAttackData, angle);

        }
        
    }

    private void CreateProjectile(RangedAttackData rangedAttackData,
        float angle)
    {
        projectileManager.ShootBullet(
            projectileSpawnPosition.position,
            RotateVector2(aimDirection, angle),
            rangedAttackData);        
    }

    private static Vector2 RotateVector2(Vector2 v,float degree)
    {
        return Quaternion.Euler(0, 0, degree) * v;
    }
}
