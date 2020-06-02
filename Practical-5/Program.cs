using System;

namespace Practical_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Console.Write("Enter infix: ");
            string infix = Console.ReadLine();
            Console.WriteLine("Postfix: ");
            string postfix = obj.infixToPostfixConverter(infix);
            Console.Write(postfix);
        }
    }
}
