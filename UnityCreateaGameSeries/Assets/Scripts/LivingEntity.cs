using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class LivingEntity:MonoBehaviour,IDamageable
{
    public float startingHealth;
    protected float health;
    protected bool dead;

    public event System.Action OnDeath;
    protected virtual void Start()
    {
        health = startingHealth;
    }
    public virtual void TeakHit(float damage,Vector3 hitPoint, Vector3 hitDirection)
    {
        // Do some stuff herer with hit var
        TakeDamage(damage);
    }

    public virtual void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0&&!dead)
        {
            Die();
        }
    }

    [ContextMenu("Self Destruct")]
    protected void Die()
    {
        dead = true;
        if (OnDeath != null)
        {
            OnDeath();
        }
        GameObject.Destroy(gameObject);
    }
}
