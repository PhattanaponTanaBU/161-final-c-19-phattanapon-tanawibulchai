using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Shape circle = new Circle("Circle", 3);
        Shape square = new Square("Square", 5);
    }
}
