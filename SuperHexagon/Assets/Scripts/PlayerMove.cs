using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float radius;
    public float playerSpeed;
    [SerializeField]
    private  float deg=0;

    Rigidbody2D rigid;
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Move();
    }

    public void Move()
    {
        deg += Time.deltaTime * playerSpeed * Input.GetAxisRaw("Horizontal");
        if(deg<0)
        {
            deg = 360;
        }
        else
        {
            var rad = Mathf.Deg2Rad * (deg);
            var x = radius * Mathf.Sin(rad);
            var y = radius * Mathf.Cos(rad);
            rigid.transform.position = new Vector3(x, y);
            Debug.Log(x + " " + y);
            rigid.transform.rotation = Quaternion.Euler(0, 0, deg * -1);
        }
    }
}
