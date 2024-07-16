using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpTest : MonoBehaviour
{
    Vector3 startPos;
    Vector3 endPos;

    public float t;
    public float width;

    public int type = 0;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        endPos = transform.position;
        endPos.x += width;

        t = 0;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos;

        if(type == 0)
        {
            // 고정된 위치 -> 등속 이동
            pos = Vector3.Lerp(startPos, endPos, t);
            transform.position = pos;
        }
        else if (type == 1)
        {
            pos = Vector3.Lerp(transform.position, endPos, t);
            transform.position = pos;
        }

        t += Time.deltaTime;
    }
}
