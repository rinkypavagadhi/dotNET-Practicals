using System;
using System.ComponentModel;

namespace Practical_8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1. Celsius to Fahrenheit\n2. Fahrenheit to Celsius\nEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter a value in Celsius:");
                    float Celsius = float.Parse(Console.ReadLine());
                    float Fahrenheit = Celsius * (9.0f / 5.0f) + 32;
                    Console.WriteLine($"Fahrenheit: {Fahrenheit}");
                    break;
                case 2:
                    Console.WriteLine("Enter a value in Fahrenheit:");
                    Fahrenheit = float.Parse(Console.ReadLine());
                    Celsius = (Fahrenheit - 32) * (5.0f / 9.0f);
                    Console.WriteLine($"Celsius: {Celsius}");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
