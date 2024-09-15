using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Made : MonoBehaviour
{
    [SerializeField]
    Rectangle rectangle;
    Shape shape;
    AreaCalculator areaCalculator;
    float goal;
    private void Start()
    {
        areaCalculator = new AreaCalculator();       
        goal=areaCalculator.GetArea(rectangle);
    }
}


