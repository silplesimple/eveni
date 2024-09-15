using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    float zPos = 10;
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
        if(zPos > 360)
        {
            zPos = 0;
        }
        zPos += roationSpeed*Time.deltaTime;
        RotationObject(PowerPos(vectorPos));
        Debug.Log(vectorPos.x);
    }

    private Vector3 PowerPos(Vector3 vectorPos,float zPos)
    {         
        return vectorPos += new Vector3(0, 0, zPos);
    }

    private Vector3 PowerPos(Vector3 vectorPos)
    {
        return vectorPos += new Vector3(0, 0, zPos);
    }

    private void RotationObject(Vector3 pos)
    {
        gameObject.transform.rotation = Quaternion.Euler(pos);
    }
}
