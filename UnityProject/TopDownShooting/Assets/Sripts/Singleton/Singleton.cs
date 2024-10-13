using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T: MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.Log("인스턴스가 비어있어 만들어 버렸습니다 데헷");
                GameObject obj;
                obj = GameObject.Find(typeof(T).Name);
                if (obj == null)
                {
                    obj = new GameObject(typeof(T).Name);
                    instance = obj.AddComponent<T>();
                }
                else
                {
                    instance = obj.GetComponent<T>();
                }
            }
        return instance;
        }
    }

    public void DontDestroySingleton(T t_instance)
    {
        instance = t_instance;
        DontDestroyOnLoad(this);        
    }
    
    
}
