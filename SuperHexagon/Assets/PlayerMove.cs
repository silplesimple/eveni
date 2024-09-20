using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Transform transform;
    
    public void Move(Vector3 Pos)
    {
        gameObject.transform.position = Pos;
    }
    
}
