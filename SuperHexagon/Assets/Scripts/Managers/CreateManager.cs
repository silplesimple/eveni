using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    public static CreateManager Instance;
    [SerializeField] private List<Transform> createWallPos;
    [SerializeField] private GameObject Wall;

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
        CreateWall();

    }

    private int RandomIndex()
    {
        int random = Random.Range(0, createWallPos.Count);
        Debug.Log("랜덤 숫자" + random+"그리고 끝숫자"+createWallPos.Count);
        return random;
    }

    public void CreateWall()
    {
        for(int i=0;i<RandomIndex();i++)
        {
            Debug.Log(i);
            Instantiate(Wall, createWallPos[i].position, createWallPos[i].rotation);
        }
    }
}
