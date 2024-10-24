using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : Obstacle
{    
    float rhombusWidthX;
    private Vector2 centerPos;
    private Vector2 startPos;    
    [SerializeField] private float distance;
    [SerializeField] private float power;
    [SerializeField] private float duration=3f;
    GameManager manager;
    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();               
    }
    void Start()
    {        
       manager=GameManager.Instance; 
       centerPos=manager.transform.position;
    }

    // Update is called once per frame 
    void FixedUpdate()
    {
        startPos = transform.position;
        //두 점 사이에 거리
        distance = (startPos - centerPos).magnitude;
        
        //Debug.Log("거리"+ distance);
        
        MoveObstacle(duration * Time.deltaTime);
        reduceObstacles(distance);
        

    }

    float GetDistance(float x1,float x2,float y1,float y2)
    {
        float width = x1 - x2;
        float height =y1-y2;

        float distance=width*width + height*height;
        Debug.Log("수식전" + distance);
        distance = Mathf.Sqrt(distance);
        Debug.Log("수식후" + distance);

        return distance;
        
    }

    

    
   
}
