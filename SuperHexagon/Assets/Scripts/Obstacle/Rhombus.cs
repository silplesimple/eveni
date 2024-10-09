using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhombus : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    float rhombusWidthX;
    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rhombusWidthX = spriteRenderer.size.x;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Invoke("SpriteWidthUp", 3f);
        
    }

    void SpriteWidthUp()
    {
        rhombusWidthX = Random.Range(1.86f,2.86f);
        //À°°¢ÇüÀÇ ³ÐÀÌ*À°°¢ÇüÀÇ Å©±â
        spriteRenderer.size = new Vector2(rhombusWidthX, 0.68f);
    }

}
