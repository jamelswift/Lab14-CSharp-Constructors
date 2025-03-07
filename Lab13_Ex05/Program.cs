using System;

class Shape
{
    private int? NumOfSide;
    
    private Shape() // คอนสตรัคเตอร์ private ที่ไม่สามารถเรียกใช้จากคลาสลูก
    {
    }
    
    // คอนสตรัคเตอร์ที่รับพารามิเตอร์
    public Shape(int NumOfSide) : this()
    {
        this.NumOfSide = NumOfSide;
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base(0) // Circle มีจำนวนด้าน 0
    {
        System.Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4) // Rectangle มีจำนวนด้าน 4
    {
        System.Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
   public Triangle() : base(3) // Triangle มีจำนวนด้าน 3
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
