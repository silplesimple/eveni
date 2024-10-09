using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance = null;
    float spawnRate = 1f;
    float nextTimeToSpawn = 0f;    


    private void Awake()
    {
        if (null == Instance)
        {
            Instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void SpawnHexagon(GameObject hexagon)
    {
        if(Time.time>nextTimeToSpawn)
        {
            Instantiate(hexagon,Vector3.zero, Quaternion.identity,gameObject.transform);
            nextTimeToSpawn=Time.time+ 1f / spawnRate;
        }
    }
}
