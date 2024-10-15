using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : Singleton<ProjectileManager>
{
    [SerializeField] private ParticleSystem impactParticleSystem;
   

    [SerializeField] private GameObject testObj;
    private ObjectPool objectPool;

    private void Awake()
    {
        DontDestroySingleton(this);
    }

    private void Start()
    {
        objectPool = GetComponent<ObjectPool>();
    }

    public void ShootBullet(Vector2 startPosition,Vector2 direction,RangedAttackData attackData)
    {
        GameObject obj = objectPool.SpawnFromPool(attackData.bulletNameTag);

        obj.transform.position = startPosition;
        RangedAttackController attackController=obj.GetComponent<RangedAttackController>();
        attackController.InitialzeAttack(direction, attackData,this);

        obj.SetActive(true);
        
    }
}