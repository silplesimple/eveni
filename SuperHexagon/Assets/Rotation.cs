using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    float x;
    public Vector3 vectorPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotationObject(PowerPos(vectorPos));
    }

    private Vector3 PowerPos(Vector3 vectorPos)
    {
        return vectorPos += new Vector3(10, 10, 10);
    }

    private void RotationObject(Vector3 pos)
    {
        gameObject.transform.rotation = Quaternion.Euler(pos);
    }
}
