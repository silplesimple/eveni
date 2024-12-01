using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�Ŵ����� Ŭ������ �ϳ��� �α����� ���
public class Singleton<T> : MonoBehaviour where T : Component
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                // �ش� ������Ʈ�� ������ �ִ� ���� ������Ʈ�� ã�Ƽ� ��ȯ�Ѵ�.
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
