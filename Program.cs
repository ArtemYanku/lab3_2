using System;
using System.Collections.Generic;

class Point
{
    public double X { get; }
    public double Y { get; }
    public string Name { get; }

    public Point(double x, double y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}

class Figure
{
    private List<Point> points = new List<Point>();

    public Figure(Point p1, Point p2, Point p3)
    {
        points.Add(p1);
        points.Add(p2);
        points.Add(p3);
    }

    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points.Add(p1);
        points.Add(p2);
        points.Add(p3);
        points.Add(p4);
    }

    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Count; i++)
        {
            Point currentPoint = points[i];
            Point nextPoint = points[(i + 1) % points.Count]; // Замикання багатокутника

            perimeter += GetSideLength(currentPoint, nextPoint);
        }
        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point A = new Point(0, 0, "A");
        Point B = new Point(0, 4, "B");
        Point C = new Point(3, 0, "C");
        Point D = new Point(3, 4, "D");

        Figure rectangle = new Figure(A, B, C, D);
        rectangle.CalculatePerimeter();

        Console.ReadKey();
    }
}


