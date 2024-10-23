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
        transform.position = new Vector2(0, duration);
    }
    protected void reduceObstacles(float duration)
    {
        if(spriteRenderer ==null)
        {
            return;
        }
        Debug.Log("�̰� �����");
        //�̰� �������� ���°Ÿ� ���غ���
        //���Ͽ��� �ٸ� �����ǿ��� �ǰ�
        
        spriteRenderer.size = new Vector2(duration * 1.4f, 1);
        if(spriteRenderer.size.x>1.4f)
        {
            
        }
        Debug.Log(spriteRenderer.size);
        
    }

}
