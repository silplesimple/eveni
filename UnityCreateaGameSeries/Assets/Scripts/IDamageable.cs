using UnityEngine;

public interface IDamageable
{
    void TeakHit(float damage, Vector3 hitPoint, Vector3 hitDirections);

    void TakeDamage(float damage);
}
