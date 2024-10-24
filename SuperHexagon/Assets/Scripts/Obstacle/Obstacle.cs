using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //������ ��ֹ� �ڵ�
    //�÷��̾ �����±�� ����
    //������Ʈ�� �پ��� ����� ����
    
    private SpriteRenderer spriteRenderer;   

    protected virtual void Awake()
    {        
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    protected void MoveObstacle(float duration)
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.zero, duration);
        DestoryObstacle();
    }
    protected void reduceObstacles(float duration)
    {
        if(spriteRenderer ==null)
        {
            return;
        }
            
        
        spriteRenderer.size = new Vector2(duration * 1.4f, 1.3f);
        if(spriteRenderer.size.x>1.4f)
        {
            
        }
        //Debug.Log(spriteRenderer.size);
        
    }
    
    private void DestoryObstacle()
    {
        if(spriteRenderer.size.x<1f)
        {
            Destroy(gameObject);
        }
    }

}
