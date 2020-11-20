using System;

namespace Chap_12_Binary_Number_System
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code: 12.1
            /*
            char[] binary = new char[65];
            int len, dcml, power, i;
            Console.Write("Enter the binary number: ");
            binary = Console.ReadLine().ToCharArray();
            dcml = 0;
            len = binary.Length;
            power = len - 1;
            for (i = 0; i < len; i++)
            {
                dcml += (int) ((binary[i] - '0') * Math.Pow(2, power));
                power--;
            }
            Console.WriteLine("Decimal value is: {0}", dcml);
            */
            #endregion

            #region Code: 12.1 Ex
            /*
            int num, binary;

            Console.Write("Enter a decimal number: ");
            num = Convert.ToInt32(Console.ReadLine());
            binary = convert(num);
            
            Console.WriteLine("The Binary is: {0}", binary);
            */
            #endregion
        }

        #region Function: 12.1 Ex
        /*
        static int convert(int num)
        {
            int i, j, binary = 0;
            j = 1;

            for (i = num; i > 0; i = i / 2)
            {
                binary = binary + (num % 2) * j;
                j = j * 10;
                num = num / 2;
            }

            return binary;
        }
        */
        #endregion
    }
}
