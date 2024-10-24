using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        pattonManager = PattonManager.Instance;
        //�� �Լ��� �ڷ�ƾ���� �ϸ��� �����ϵ���
            
    }

    private void Start()
    {
        StartCoroutine("Patton");        
    }

    IEnumerator Patton()
    {
        while (true)
        {
            spawnFloat = Random.Range(0.5f, 1);            
            int randomPatton = Random.Range(0, 6);
            Debug.Log("�ڷ�ƾ"+randomPatton);
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
        //SpawnManager.Instance.SpawnHexagon(hexagonPrefab);
    }

}
