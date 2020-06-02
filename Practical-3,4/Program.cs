using System;


namespace Practical_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Console.Write("Press 1: Binary to Decimal\nPress 2: Decimal to Hexadecimal\nPress 3: Decimal to Binary\nPress 4: Decimal to Octal\nEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    obj.BtD("100101");
                    break;
                case 2:
                    obj.DtH(54);
                    break;
                case 3:
                    obj.DtB(54);
                    break;
                case 4:
                    obj.DtO(54);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
