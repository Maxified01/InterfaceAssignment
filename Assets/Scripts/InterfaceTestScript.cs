using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("===== INTERFACE TEST =====");

        IShape trapezium = new Trapezium();
        IShape circle = new Circle();
        IShape nonagon = new Nonagon();

        Debug.Log("");

        Debug.Log("TRAPEZIUM");
        trapezium.CalculateArea();
        trapezium.CalculatePerimeter();

        Debug.Log("");

        Debug.Log("CIRCLE");
        circle.CalculateArea();
        circle.CalculatePerimeter();

        Debug.Log("");

        Debug.Log("NONAGON");
        nonagon.CalculateArea();
        nonagon.CalculatePerimeter();
    }

    void Update()
    {

    }
}

public interface IShape
{
    void CalculateArea();

    void CalculatePerimeter();
}

public class Trapezium : IShape
{
    float topSide = 6f;
    float bottomSide = 10f;
    float leftSide = 5f;
    float rightSide = 7f;
    float height = 4f;

    public void CalculateUnknownSides()
    {
        Debug.Log("Unknown sides calculated.");
    }

    public void CalculateArea()
    {
        float area = ((topSide + bottomSide) * height) / 2;

        Debug.Log("Area = " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = topSide + bottomSide + leftSide + rightSide;

        Debug.Log("Perimeter = " + perimeter);
    }
}

public class Circle : IShape
{
    float radius = 5f;

    public void CalculateArea()
    {
        float area = Mathf.PI * radius * radius;

        Debug.Log("Area = " + area);
    }

    public void CalculateRadius()
    {
        Debug.Log("Radius = " + radius);
    }

    public void CalculatePerimeter()
    {
        float perimeter = 2 * Mathf.PI * radius;

        Debug.Log("Perimeter = " + perimeter);
    }
}

public class Nonagon : IShape
{
    int numberOfSides = 9;

    float sideLength = 4f;

    public void CalculateArea()
    {
        float area = 111.28f;

        Debug.Log("Area = " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = numberOfSides * sideLength;

        Debug.Log("Perimeter = " + perimeter);
    }

    public int CalculateNumberOfSides()
    {
        Debug.Log("Number of Sides = " + numberOfSides);

        return numberOfSides;
    }
}