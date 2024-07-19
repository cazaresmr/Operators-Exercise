using System;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {difference}");
            Console.WriteLine($"{a} * {b} is {product}");
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radius of your circle?");

            try
            {
                double radius = double.Parse(Console.ReadLine());

                if (radius <= 0)
                {
                    Console.WriteLine("Radius must be a positive number.");
                }
                else
                {
                    double area = AreaOfCircle(radius);
                    Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value for the radius.");
            }
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
