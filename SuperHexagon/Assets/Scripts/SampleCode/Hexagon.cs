using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    int OnHexagon;
    float shrinkSpeed = 3f;
    Rigidbody2D rigidbody2D;
    [SerializeField]
    GameObject[] Rhombus;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        transform.localScale = Vector3.one * 10f;
       
        for(int i=0;i<Rhombus.Length;i++)
        {
            OnHexagon = Random.Range(0,10);
            if(OnHexagon>4)
            {
                Rhombus[i].SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        transform.rotation=GameManager.Instance.center.transform.rotation; 
        if(transform.localScale.x <=0.05f)
        {
            Destroy(gameObject);
        }
    }

    void HexagonDuration()
    {
        //Çí»ç°ïÀ» ÁÙ¾îµê¸é¼­ ¿À´Â ±â´É

    }
}
