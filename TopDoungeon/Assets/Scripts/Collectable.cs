using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : Collidable
{
    // Logic
    protected bool collected;

    protected override void OnCollide(Collider2D coll)
    {
        //Debug.Log("�ڽ� �Լ� üũ");
        if (coll.name == "player")
        {
            OnCollect();
            //Debug.Log("�÷��̾� üũ");
        }

        base.OnCollide(coll);
    }

    protected virtual void OnCollect()
    {
        collected = true;        
    }
}
