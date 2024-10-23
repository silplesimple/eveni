using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : Obstacle
{
    
    float rhombusWidthX;
    private Vector2 centerPos;
    private Vector2 startPos;    
    [SerializeField] private float duration;
    [SerializeField] private float power;
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
        duration = (startPos - centerPos).magnitude;
        
        Debug.Log("거리"+duration);
        
        //MoveObstacle(duration);
        reduceObstacles(duration);
        //시작거리와 끝거리를 계속 줄어들게 하기
        //Debug.Log("처음과 끝에 거리" + duration);
        //Invoke("SpriteWidthUp", 3f);        
        //듀렉션이 바뀌는지 궁금
        //이게 어떻게 줄어들게 할지 궁금

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
