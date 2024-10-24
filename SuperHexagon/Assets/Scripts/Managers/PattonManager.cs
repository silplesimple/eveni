using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PattonManager : MonoBehaviour
{
    public static PattonManager Instance;
    [SerializeField] private List<Transform> createWallPos;
    [SerializeField] private GameObject Wall;
    private List<int> patton;
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
        }        

    }

    public void WallPatton(int one, int two, int three, int fwo, int five)
    {
        patton = new List<int> { one, two, three, fwo, five };
        for (int i = 0; i < patton.Count; i++)
        {
            var WallPos = createWallPos[patton[i]];
            Instantiate(Wall, WallPos.position, WallPos.rotation, WallPos);
        }
    }
    public void WallPatton(int one, int two, int three, int fwo)
    {
        patton = new List<int> { one, two, three, fwo};
        for (int i = 0; i < patton.Count; i++)
        {
            var WallPos = createWallPos[patton[i]];
            Instantiate(Wall, WallPos.position, WallPos.rotation, WallPos);
        }
    }
    public void WallPatton(int one, int two, int three)
    {
        patton = new List<int> { one, two, three };
        for (int i = 0; i < patton.Count; i++)
        {
            var WallPos = createWallPos[patton[i]];
            Instantiate(Wall, WallPos.position, WallPos.rotation, WallPos);
        }
    }
    public void WallPatton(int one, int two)
    {
        patton = new List<int> { one, two };
        for (int i = 0; i < patton.Count; i++)
        {
            var WallPos = createWallPos[patton[i]];
            Instantiate(Wall, WallPos.position, WallPos.rotation, WallPos);
        }
    }
    public void WallPatton(int one)
    {
        patton = new List<int> { one };
        for (int i = 0; i < patton.Count; i++)
        {
            var WallPos = createWallPos[patton[i]];
            Instantiate(Wall, WallPos.position, WallPos.rotation, WallPos);
        }
    }
    public void WallPatton(int one,int two,int three,int fwo,int five,int six)
    {
        patton = new List<int> { one, two, three, fwo, five, six };
        for (int i = 0; i < patton.Count; i++)
        {
            var WallPos = createWallPos[patton[i]];
            Instantiate(Wall, WallPos.position, WallPos.rotation, WallPos);
        }
    }
}
