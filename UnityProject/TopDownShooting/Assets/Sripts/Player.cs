using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float timeDelta;
    // Start is called before the first frame update
    void Start()
    {
        timeDelta = 0f;   
    }

    // Update is called once per frame
    void Update()
    {
        timeDelta = Time.deltaTime;
        //Debug.Log(timeDelta);
    }
}
