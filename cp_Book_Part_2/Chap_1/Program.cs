using System;

namespace Chap_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code: 1-1
            /*
            int i;

            for (i = 33; i <= 123; i++)
            {
                Console.WriteLine($"ASCII Code for {Convert.ToChar(i)} is {i}");
            }
            */
            #endregion

            #region Code: 1-2
            /*
            char small_letter, capital_letter;

            Console.Write("Please enter a small letter: ");
            small_letter = char.Parse(Console.ReadLine());
            capital_letter = (char) (small_letter - 32);
            Console.WriteLine($"The capital letter is: {capital_letter}");
            */
            #endregion

            #region Code: 1-3
            /*
            unsafe
            {
                char ch1 = 'A', ch2 = 'B';
                char* ch1ptr = &ch1;
                char* ch2ptr = &ch2;
                
                int n1 = 100, n2 = 100000;
                int* n1ptr = &n1;
                int* n2ptr = &n2;

                Console.WriteLine($"Value of ch1 = {ch1}");
                Console.WriteLine($"Address of ch1 = {(long)ch1ptr:X}");

                Console.WriteLine($"Value of ch2 = {ch2}");
                Console.WriteLine($"Address of ch2 = {(long)ch2ptr:X}");

                Console.WriteLine($"Value of n1 = {n1}");
                Console.WriteLine($"Address of ch1 = {(long)n1ptr:X}");

                Console.WriteLine($"Value of n1 = {n2}");
                Console.WriteLine($"Address of ch1 = {(long)n2ptr:X}");
            }
            */
            #endregion

            #region Code: 1-4
            /*
            unsafe
            {
                int[] ara = { 50, 60, 70, 80, 90 };
                Console.WriteLine($"Value of Array: {ara[0]}, {ara[1]}, {ara[2]}, {ara[3]}, {ara[4]}");

                fixed (int* addressOfArray = ara)
                {
                    Console.WriteLine($"Address of ara is {(long)addressOfArray:X}");
                }

                for (int i = 0; i < ara.Length; i++)
                {
                    fixed (int* addressOfArray = &ara[i])
                    {
                        Console.WriteLine($"Address of ara[{i}] is {(long)addressOfArray:X}");
                    }
                }
            }
            */
            #endregion

            #region Code: 1-5
            /*
            Console.WriteLine($"Size of byte: {sizeof(byte)}");            
            Console.WriteLine($"Size of sbyte: {sizeof(sbyte)}");            
            Console.WriteLine($"Size of short: {sizeof(short)}");                   
            Console.WriteLine($"Size of int: {sizeof(int)}");
            Console.WriteLine($"Size of long: {sizeof(long)}");
            Console.WriteLine($"Size of float: {sizeof(float)}");
            Console.WriteLine($"Size of double: {sizeof(double)}");
            Console.WriteLine($"Size of decimal: {sizeof(decimal)}");
            Console.WriteLine($"Size of char: {sizeof(char)}");
            Console.WriteLine($"Size of bool: {sizeof(bool)}");
            Console.WriteLine($"Size of ushort: {sizeof(ushort)}");
            Console.WriteLine($"Size of uint: {sizeof(uint)}");            
            Console.WriteLine($"Size of ulong: {sizeof(ulong)}");
            https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
            */
            #endregion
        }

        #region Function: 1-2
        /*
        static int checkDigit(char ch)
        {
            if (ch >= 48 && ch <= 57)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        */
        #endregion
    }
}
