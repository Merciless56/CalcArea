using System;

namespace Area
{
    public class Circle
    {
        double area;
        public Circle(double radius)
        {
            this.area = Math.Round(Math.PI * Math.Pow(radius, 2), 3);
        }
        public void Print() => Console.WriteLine($"Площадь круга: {area}");
    }

    public class Triangle
    {
        double area;
        bool isRect=false;
        public Triangle(double side_1, double side_2, double side_3)
        {
            double p = (side_1 + side_2 + side_3) / 2;
            this.area = Math.Round(Math.Sqrt(p * (p - side_1) * (p - side_2) * (p - side_3)), 3);

            if ((side_1 * side_1 + side_2 * side_2 == side_3 * side_3) || (side_1 * side_1 + side_3 * side_3 == side_2 * side_2) || (side_3 * side_3 + side_2 * side_2 == side_1 * side_1))
            {
                isRect = true;
            }

        }
        public void Print() 
        { 
            Console.WriteLine($"Площадь треугольника: {area}");
            if (isRect)
            {
                Console.WriteLine("Этот треугольник прямоугольный");
            }
            else
            {
                Console.WriteLine("Этот треугольник не прямоугольный");
            }
        }
    }
}
