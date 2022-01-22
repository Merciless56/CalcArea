using System;
using Area;

namespace CalcArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, r;
            r = Read("Введите радиус круга: ");
            a = Read("Введите сторону треугольника A: ");
            b = Read("Введите сторону треугольника B: ");
            c = Read("Введите сторону треугольника C: ");
            Circle c1 = new Circle(r);
            c1.Print();
            Triangle t1 = new Triangle(a, b, c);
            t1.Print();
        }
        static double Read(string prompt, Predicate<double> condition = null)
        {
            double result;
            do Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out result) || (condition != null && !condition(result)));

            return result;
        }
    }
}
