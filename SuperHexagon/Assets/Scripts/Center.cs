using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Center : MonoBehaviour
{
    private float zRot = 10;
    private float rotationSpeed =100;
    private Vector3 vectorPos;
    
    public void RotationCenter()
    {
        if (zRot > 360)
        {
            Debug.Log("작동했습니다.");
            zRot = 0;
        }
        zRot += rotationSpeed * Time.deltaTime;
        RotationObject(PowerPos(vectorPos, zRot));
        Debug.Log(vectorPos.x);
    }
    private Vector3 PowerPos(Vector3 vectorPos, float zRot)
    {
        return vectorPos += new Vector3(0, 0, zRot);
    }

    private void RotationObject(Vector3 pos)
    {
        gameObject.transform.rotation = Quaternion.Euler(pos);
    }

    
}
