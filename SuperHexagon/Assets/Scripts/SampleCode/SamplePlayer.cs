using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplePlayer : MonoBehaviour
{
    public float speed = 650f;

    float movement;
  
    // Update is called once per frame
    void Update()
    {
        movement=Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero,Vector3.forward,movement * speed * Time.fixedDeltaTime);
    }
}
