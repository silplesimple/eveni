using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownRangeEnemyController : TopDownEnemyController
{
    [SerializeField] private float followRange = 10f;
    [SerializeField] private float ShootRange = 1f;

    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        float distance = DistanceToTarget();
        Vector2 direction = DirectionToTarget();

        IsAttacking = false;
        if(distance<=followRange)
        {            
            if(distance<=ShootRange)
            {
                int layerMaskTarget = Stats.CurrentStates.attackSO.target;
                RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, followRange, (1 << LayerMask.NameToLayer("Level")) | layerMaskTarget);
                Debug.DrawRay(transform.position, direction);

                if (hit.collider != null && layerMaskTarget == (layerMaskTarget | (1 << hit.collider.gameObject.layer)))
                {
                    CallLookEvent(direction);
                    CallMoveEvent(Vector2.zero);
                    IsAttacking = true;
                }
                else
                {
                    Debug.Log("이동도 됩니다");
                    CallMoveEvent(direction);
                }
            }
            else
            {
                CallMoveEvent(direction);
            }
        }
        else
        {
            CallMoveEvent(direction);
        }
    }
}
