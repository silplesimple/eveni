using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1.3f;
    public GameObject hexagonPrefab;

    float nextTimeToSpawn = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>nextTimeToSpawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time +1f/spawnRate;
        }
    }
    
        
       
    

    

}
