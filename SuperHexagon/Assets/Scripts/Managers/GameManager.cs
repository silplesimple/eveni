using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;
using Scene = UnityEngine.SceneManagement.Scene;

public class GameManager : MonoBehaviour
{
    private float spawnFloat = .0f;
    public static GameManager Instance =null;    
    private PattonManager pattonManager;
    
    [SerializeField] private Center center;
    

    private void Awake()
    {
        if (null==Instance)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Instance = null;
        }
        pattonManager = PattonManager.Instance;
            
    }

    private void Start()
    {
        center= FindObjectOfType<Center>();
        StartCoroutine("Patton");        
    }

    private void OnEnable()
    {
        // Action - 델리게이트
        SceneManager.sceneLoaded += SceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= SceneLoaded;
    }

    private void SceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
    {
        center= FindObjectOfType<Center>();
    }


    IEnumerator Patton()
    {
        while (true)
        {
            spawnFloat = Random.Range(1f, 3);            
            int randomPatton = Random.Range(0, 6);
            //Debug.Log("코루틴"+randomPatton);
            switch(randomPatton)
            {
                case 1:
                    pattonManager.WallPatton(0, 2, 4);
                    break;
                case 2:
                    pattonManager.WallPatton(1, 3, 5);
                    break;
                case 3:
                    pattonManager.WallPatton(1, 2, 3, 4, 5);
                    break;
                case 4:
                    pattonManager.WallPatton(0, 1, 3, 4);
                    break;
                case 5:
                    pattonManager.WallPatton(1);
                    break;
                default: 
                    break;

            }
            
            yield return new WaitForSeconds(spawnFloat);
        }
        
    }

    private void Update()
    {
        center.RotationCenter();      
        
    }
    
   

}
