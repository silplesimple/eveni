using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//매니저급 클래스를 하나만 두기위해 사용
public class Singleton<T> : MonoBehaviour where T : Component
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                // 해당 컴포넌트를 가지고 있는 게임 오브젝트를 찾아서 반환한다.
                instance = (T)FindAnyObjectByType(typeof(T));

                if(instance ==null)
                {
                    SetupInstance();                    
                }
            }
            return instance;
        }
        
    }
    protected virtual void Awake()
    {
        RemoveDuplicates();       
    }
    private static void SetupInstance()
    {
        instance = (T)FindObjectOfType(typeof(T));

        if(instance ==null)
        {
            GameObject gameObj = new GameObject();
            gameObj.name = typeof(T).Name;
            instance = gameObj.AddComponent<T>();
            DontDestroyOnLoad(gameObj);
        }
    }

    private void RemoveDuplicates()
    {
        if(instance==null)
        {
            instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
