# Interface Assignment - Unity C#

## My Information

**Name:** Anthony Emoh
**Course:** Advanced C# Programming

**Assignment:** Interface Implementation in Unity

---

## Project Description

This project demonstrates how to use interfaces in C# within Unity.

A common interface named `IShape` is being implemented by three different shape classes:

* Trapezium
* Circle
* Nonagon

Each class is implementing the common methods defined in the `IShape` interface while also containing shape-specific methods where applicable.

This project tests each shape by creating objects and calling their methods from the `Start()` method of the `InterfaceTestScript`.

---

## What To Do

* Create an interface named `IShape`.
* Implement the interface in multiple classes.
* Demonstrate polymorphism through interface references.
* Display results using `Debug.Log()` in the Unity Console.
* Apply one SOLID principle.

---

## The SOLID Principle Used

### Dependency Inversion Principle (DIP)

This project follows the Dependency Inversion Principle by programming against the `IShape` interface rather than the concrete classes.

Examples:

```csharp
IShape trapezium = new Trapezium();
IShape circle = new Circle();
IShape nonagon = new Nonagon();
```

The program depends on the abstraction (`IShape`) instead of the implementation (`Trapezium`, `Circle`, and `Nonagon`), making the code easier to extend and maintain.

---

## Project Structure

```text
Assets
└── Scripts
    └── Interfaces
        └── InterfaceTestScript.cs
```

---

## Shapes Implemented

### Trapezium

Methods:

* CalculateArea()
* CalculatePerimeter()
* CalculateUnknownSides()

### Circle

Methods:

* CalculateArea()
* CalculatePerimeter()
* CalculateRadius()

### Nonagon

Methods:

* CalculateArea()
* CalculatePerimeter()
* CalculateNumberOfSides()

---

## How to Run

1. Open the project in Unity.
2. Open the sample scene or create a new scene.
3. Create an empty GameObject.
4. Attach the `InterfaceTestScript` component.
5. Press **Play**.
6. View the results in the Unity Console.

---

## Expected Output

```text
===== INTERFACE TEST =====

TRAPEZIUM
Area = 32
Perimeter = 28

CIRCLE
Area = 78.53982
Perimeter = 31.41593

NONAGON
Area = 111.28
Perimeter = 36
```

---

## Repository Contents

* Unity Project
* C# Scripts
* README.md
* Assignment Documentation

---

## Author

**Name:** Anthony Emoh
