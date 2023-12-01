using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double squareSide = InputHelper.ReadDouble("Nhap do dai canh cua hinh vuong: ");
        Square square = new Square(squareSide);

        double rectangleLength = InputHelper.ReadDouble("Nhap chieu dai cua hinh chu nhat: ");
        double rectangleWidth = InputHelper.ReadDouble("Nhap chieu rong cua hinh chu nhat: ");
        Rectangle rectangle = new Rectangle(rectangleLength, rectangleWidth);

        double triangleBase = InputHelper.ReadDouble("Nhap do dai co so cua tam giac: ");
        double triangleHeight = InputHelper.ReadDouble("Nhap chieu cao cua tam giac: ");
        Triangle triangle = new Triangle(triangleBase, triangleHeight);

        double circleRadius = InputHelper.ReadDouble("Nhap Ban Kinh Cua Hinh Tron: ");
        Circle circle = new Circle(circleRadius);

        double squareArea = square.CalculateArea();
        double rectangleArea = rectangle.CalculateArea();
        double triangleArea = triangle.CalculateArea();
        double circleArea = circle.CalculateArea();

        Console.WriteLine("Dien tich hinh vuong: " + squareArea);
        Console.WriteLine("Dien tich hinh chu nhat: " + rectangleArea);
        Console.WriteLine("Dien tich tam giac: " + triangleArea);
        Console.WriteLine("Dien tich hinh tron: " + circleArea);
    }
}