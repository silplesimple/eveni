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
        //Debug.Log("자식 함수 체크");
        if (coll.name == "player")
        {
            OnCollect();
            //Debug.Log("플레이어 체크");
        }

        base.OnCollide(coll);
    }

    protected virtual void OnCollect()
    {
        collected = true;        
    }
}
