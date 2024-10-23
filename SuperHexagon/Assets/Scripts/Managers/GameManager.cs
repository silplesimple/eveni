using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float SpawnFloat = 0f;
    public static GameManager Instance =null;
    public Center center;
    
    

    private void Awake()
    {
        if (null==Instance)
        {
            Instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        //center = GetComponentInChildren<Center>();
    }

    private void Update()
    {
        //center.RotationCenter();      
        //SpawnManager.Instance.SpawnHexagon(hexagonPrefab);
    }

}
