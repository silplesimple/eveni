using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavePointIndex=0;

    private void Start()
    {
        target = Waypoints.points[0];
    }

    private void Update()
    {
        //함수로 어떻게 바꿀수 있는지 생각
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed *Time.deltaTime,Space.World);

        if(Vector3.Distance(transform.position,target.position)<=0.2f)
        {
            GetNextWaypoint();
        }
    }

    private void GetNextWaypoint()
    {
        if(wavePointIndex>=Waypoints.points.Length-1)
        {
            Destroy(gameObject);
            return;
        }
        wavePointIndex++;
        target = Waypoints.points[wavePointIndex];
    }
}
