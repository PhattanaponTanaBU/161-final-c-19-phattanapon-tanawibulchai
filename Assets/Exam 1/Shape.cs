using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape
{
    //Attributes
    protected string shapeName;

    //Method
    public Shape(string newShapeName)
    {
        shapeName = newShapeName;
    }

    protected void Initialize(string newShapeName)
    {
        Draw();
        Resize();
        CalculateArea();
        Debug.Log($"{shapeName} area is {CalculateArea()}");
    }

    public abstract float CalculateArea();

    public virtual void Resize()
    {
        Debug.Log("Resizing Shape...");
    }

    public void Draw()
    {
        Debug.Log($"Drawing {shapeName}");
    }

}
