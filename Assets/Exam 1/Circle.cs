using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Circle : Shape
{
    //Attributes
    private float radius;

    public Circle(string newShapeName, float newRadius) : base(newShapeName)
    {
        radius = newRadius;
        Initialize(newShapeName);

    }

    //Method
    public override float CalculateArea()
    {
        return Mathf.PI * radius * radius;
    }
    public override void Resize()
    {
        base.Resize();
        Debug.Log("Circle is resized suscessfully!.");
        Debug.Log($"Circle radius is {radius}.");
    }

}
