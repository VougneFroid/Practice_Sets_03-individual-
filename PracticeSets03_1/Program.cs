using System;

namespace Practice_Set_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to triangle area calculator!!\n");

            Console.Write("Enter the 'a' value: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the 'b' value: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the 'c' value: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double area = Triangle_Angle(a, b, c);
            Console.WriteLine($"The area of this triangle is {area}");
        }

        static double Triangle_Angle(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
    }
}