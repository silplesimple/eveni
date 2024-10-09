using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class AreaCalculator 
{
    public float GetArea(Shape shape)
    {
        return shape.CalculateArea();
    }
    
    public float GetRectangleArea(Rectangle rectangle)
    {
        return rectangle.width * rectangle.height;
    }

    public float GetCircleArea(Circle circle)
    {
        return circle.radius * circle.radius * Mathf.PI;
    }
}

[System.Serializable]
public class Rectangle : Shape
{
    public float width;
    public float height;
    
    public override float CalculateArea()
    {        
        return width * height;
    }
}

[SerializeField]
public class Circle : Shape
{
    public float radius;

    public override float CalculateArea()
    {
        return radius * radius * Mathf.PI;
    }
}
