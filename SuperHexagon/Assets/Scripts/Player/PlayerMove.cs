using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector2 velocity;
    Rigidbody2D rigid2D;
    
    float deg;

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }
    public void Move(Vector3 playerVelocity)
    {
        velocity.x = playerVelocity.x;
        velocity.y = playerVelocity.y;

        gameObject.transform.position = velocity;
        //Vector3 playerVector3 = new Vector3(pos, pos, 0);
        //gameObject.transform.position += playerVector3;
        ////gameObject.transform.position = Quaternion.Euler(playerVector3);
        ////vector3.x=Mathf.Abs(vector3.x);
        //Debug.Log($"플레이어 좌표 x:{playerVector3.x} y:{playerVector3.y}");        
    }

    private void FixedUpdate()
    {
        Debug.Log($"x:{velocity.x} y:{velocity.y}");
        rigid2D.MovePosition(rigid2D.position + velocity * Time.fixedDeltaTime);        
    }
}
