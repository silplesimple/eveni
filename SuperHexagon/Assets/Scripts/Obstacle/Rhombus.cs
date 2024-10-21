using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhombus : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    float rhombusWidthX;
    [SerializeField] Transform endPos;
    [SerializeField] Transform startPos;
    [SerializeField] float duration;
    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rhombusWidthX = spriteRenderer.size.x;
        gameObject.transform.position = startPos.position;
    }
    void Start()
    {
        
    }

    // Update is called once per frame 
    void FixedUpdate()
    {
        duration = (startPos.position - endPos.position).magnitude;
        Debug.Log("처음과 끝에 거리" + duration);
        //Invoke("SpriteWidthUp", 3f);        

    }

    
    void SpriteWidthUp()
    {
        rhombusWidthX = Random.Range(1.86f,2.86f);
        //육각형의 넓이*육각형의 크기
        spriteRenderer.size = new Vector2(rhombusWidthX, 0.68f);
    }

}
