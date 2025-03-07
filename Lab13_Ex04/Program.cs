using System;

class Shape
{
    private int? NumOfSide;
    
    // เปลี่ยนเป็น protected เพื่อให้คลาสลูกสามารถเข้าถึงได้
    protected Shape()
    {
        System.Console.WriteLine("This is some shape with unknown side");
    }

    public Shape(int NumOfSide)
    {
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base() // เรียกคอนสตรัคเตอร์ของ Shape
    {
        System.Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4) // เรียกคอนสตรัคเตอร์ของ Shape ที่รับพารามิเตอร์
    {
        System.Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
    public Triangle() : base(3) // เรียกคอนสตรัคเตอร์ของ Shape ที่รับพารามิเตอร์
    {
        System.Console.WriteLine("This is a triangle");
    }
}

class Program
{
    static void Main()
    {
        var circle = new Circle();
        var rectangle = new Rectangle();
        var triangle = new Triangle();
    }
}
