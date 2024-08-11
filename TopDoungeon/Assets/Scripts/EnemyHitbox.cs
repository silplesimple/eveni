using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : Collidable
{
    //Damage
    public int damage =1;
    public float pushForce=5;

    protected override void OnCollide(Collider2D coll)
    {
        if(coll.tag=="Fighter"&&coll.name=="player")
        {
            Debug.Log("������ ���Ŀ�~");
            //Create a new damage object,befor sending it o the player
            Damage dmg = new Damage
            {
                damageAmount = damage,
                origin = transform.position,
                pushForce = pushForce
            };

            coll.SendMessage("ReceiveDamage", dmg);
        }
    }
}
