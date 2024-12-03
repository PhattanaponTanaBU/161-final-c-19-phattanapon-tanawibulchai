using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    //Attributes
    private int side;

    public Square(string newShapeName, int newSide) : base(newShapeName)
    {
        side = newSide;
        Initialize(newShapeName);
    }

    //Method
    public override float CalculateArea()
    {
        return side * side;
    }

    public override void Resize()
    {
        base.Resize();
        Debug.Log("Square is resized suscessfully!");
        Debug.Log($"Square size is {side}.");
    }
}
