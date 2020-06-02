using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_3_4
{
    class Class1
    {
        public void BtD(string inp)
        {
            int Decimal = 0, temp, i = 0;
            int binaryValue = int.Parse(inp);
            while (binaryValue > 0)
            {
                temp = (binaryValue % 10);
                Decimal += (temp * (int)Math.Pow(2, i));
                i++;
                binaryValue /= 10;
            }
            string Result = "Binary: " + inp +  " is converted to Decimal: " + Decimal;
            Console.WriteLine(Result);

        }
        public void DtH(int inp)
        {
            string Result = "Decimal: " + inp + " is converted to Hexadecimal: ";
            int value = inp; 
            int i;
            int[] hexadecimalString = new int[10];
            for (i = 0; value > 0; i++)
            {
                hexadecimalString[i] = (value % 16);
                value /= 16;
            }
            i--;
            for (; i >= 0; i--)
            {
                switch (hexadecimalString[i])
                {
                    case 10: Result += "A"; break;
                    case 11: Result += "B"; break;
                    case 12: Result += "C"; break;
                    case 13: Result += "D"; break;
                    case 14: Result += "E"; break;
                    case 15: Result += "F"; break;
                    default: Result += hexadecimalString[i].ToString(); break;
                }
            }
            Console.WriteLine(Result);
        }
        public void DtB(int inp)
        {
            string Result = "Decimal: " + inp + " is converted to Binary: ";
            int value = inp; 
            int i;
            int[] binaryString = new int[10];
            for (i = 0; value > 0; i++)
            {
                binaryString[i] = (value % 2);
                value = value / 2;
            }
            i--;
            for (; i >= 0; i--)
            {
                Result += binaryString[i].ToString();
            }
            Console.WriteLine(Result);

        }
        public void DtO(int inp)
        {
            string Result = "Decimal: " + inp + " is converted to Octal: ";
            int value = inp; 
            int i;
            int[] octalString = new int[10];
            for (i = 0; value > 0; i++)
            {
                octalString[i] = (value % 8);
                value = value / 8;
            }
            i--;
            for (; i >= 0; i--)
            {
                Result += octalString[i].ToString();
            }
            Console.WriteLine(Result);

        }

    }
}
