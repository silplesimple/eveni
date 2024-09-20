using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    float zRot = 10;
    [SerializeField]
    float roationSpeed;
    public Vector3 vectorPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(zRot > 360)
        {
            zRot = 0;
        }
        zRot += roationSpeed*Time.deltaTime;
        RotationObject(PowerPos(vectorPos));
        Debug.Log(vectorPos.x);
    }

    private Vector3 PowerPos(Vector3 vectorPos,float zRot)
    {         
        return vectorPos += new Vector3(0, 0, zRot);
    }

    private Vector3 PowerPos(Vector3 vectorPos)
    {
        return vectorPos += new Vector3(0, 0, zRot);
    }

    private void RotationObject(Vector3 pos)
    {
        gameObject.transform.rotation = Quaternion.Euler(pos);
    }
}
