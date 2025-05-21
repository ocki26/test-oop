using System;
// Define an abstract base class Shape
public abstract class Shape
{
    // Declare an abstract method without implementation
    public abstract double Area();
}
// Create a concrete class Circle that inherits from Shape
public class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    // Implement the abstract method from the base class
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
// Create a concrete class Rectangle that inherits from Shape
public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }
    // Implement the abstract method from the base class
    public override double Area()
    {
        return Length * Width;
    }
}
