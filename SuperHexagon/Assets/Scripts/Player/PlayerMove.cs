using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    Vector3 playerVector;
    [SerializeField]
    float isPlayerMove;

    public void Move(Transform playerRot,float playerSpeed)
    {      
        
        playerSpeed *= -1;
        
        if(playerVector.z >360|| playerVector.z < -360)
        {
            playerVector.z = 0;
        }
        playerVector += new Vector3(0, 0, playerSpeed);
        playerRot.rotation = Quaternion.Euler(playerVector);
        
        //Vector3 playerVector3 = new Vector3(pos, pos, 0);
        //gameObject.transform.position += playerVector3;
        ////gameObject.transform.position = Quaternion.Euler(playerVector3);
        ////vector3.x=Mathf.Abs(vector3.x);
        //Debug.Log($"플레이어 좌표 x:{playerVector3.x} y:{playerVector3.y}");        
    }    
}
