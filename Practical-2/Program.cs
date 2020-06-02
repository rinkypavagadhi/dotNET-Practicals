using System;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Country: ");
            string country = Console.ReadLine();
            Console.WriteLine("Hello, " + name + " from " + country);
        }
    }
}
