using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //재사용할 장애물 코드
    //플레이어를 때리는기능 재사용
    //오브젝트가 줄어드는 기능을 재사용
    
    private SpriteRenderer spriteRenderer;   

    protected virtual void Awake()
    {        
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    protected void MoveObstacle(float duration)
    {        
        transform.position = new Vector2(0, duration);
    }
    protected void reduceObstacles(float duration)
    {
        if(spriteRenderer ==null)
        {
            return;
        }
        Debug.Log("이거 실행됨");
        //이거 패턴으로 엮는거만 잘해보자
        //패턴엮고 다른 포지션에도 되게
        
        spriteRenderer.size = new Vector2(duration * 1.4f, 1);
        if(spriteRenderer.size.x>1.4f)
        {
            
        }
        Debug.Log(spriteRenderer.size);
        
    }

}
