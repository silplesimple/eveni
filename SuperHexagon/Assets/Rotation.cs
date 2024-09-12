using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    float ParentPower = 10;
    public Vector3 vectorPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ParentPower += 10*Time.deltaTime;
        RotationObject(PowerPos(vectorPos));
        Debug.Log(vectorPos.x);
    }

    private Vector3 PowerPos(Vector3 vectorPos)
    {        
        return vectorPos += new Vector3(10*ParentPower, 10*ParentPower, 10*ParentPower);
    }

    private void RotationObject(Vector3 pos)
    {
        gameObject.transform.rotation = Quaternion.Euler(pos);
    }
}
