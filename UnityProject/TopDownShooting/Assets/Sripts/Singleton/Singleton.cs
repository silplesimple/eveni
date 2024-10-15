using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T: MonoBehaviour
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {                
                GameObject obj;
                obj = GameObject.Find(typeof(T).Name);
                if (obj == null)
                {
                    obj = new GameObject(typeof(T).Name);
                    _instance = obj.AddComponent<T>();
                }
                else
                {
                    _instance = obj.GetComponent<T>();
                }
            }
        return _instance;
        }
    }

    protected void DontDestroySingleton(T instance)
    {
        _instance = instance;
        DontDestroyOnLoad(instance);        
    }
}
