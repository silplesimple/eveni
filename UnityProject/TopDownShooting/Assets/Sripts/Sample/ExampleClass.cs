using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public int publicVariable;
    private int privateVariable;

    [SerializeField]
    private int SerializeFieldVariable;

    private void Start()
    {
        publicVariable = 10;
        privateVariable = 20;
        SerializeFieldVariable = 30;
    }
}
