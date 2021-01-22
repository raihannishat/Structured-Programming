using System;

namespace Chap_05_Bitwise_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code: 5-1
            /*
            int a, b;
            
            a = 0;
            b = ~a;
            Console.WriteLine($"a = {a}, b = {b}");

            a = 1;
            b = ~a;
            Console.WriteLine($"a = {a}, b = {b}");
            */
            #endregion

            #region Code: 5-2
            /*
            int n, x, m;

            while (true)
            {
                Console.Write("Please enter your number (0 to exit): ");
                n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    break;
                }

                Console.Write("How many bits you want to shift left? ");
                x = int.Parse(Console.ReadLine());
                
                m = n << x;
                
                Console.WriteLine($"Result is {m}\n");
            }
            */
            #endregion

            #region Code: 5-2 Ex
            /*
            int n, x, m;

            while (true)
            {
                Console.Write("Please enter your number (0 to exit): ");
                n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    break;
                }

                Console.Write("How many bits you want to shift right? ");
                x = int.Parse(Console.ReadLine());

                m = n >> x;

                Console.WriteLine($"Result is {m}\n");
            }
            */
            #endregion

            #region Code: 5-3
            /*
            int n1 = 5, n2 = 6, n3;

            n3 = n1 & n2;

            Console.WriteLine($"{n1} & {n2} = {n3}");
            */
            #endregion

            #region Code: 5-4
            /*
            int n1 = 5, n2 = 6, n3;

            n3 = n1 | n2;

            Console.WriteLine($"{n1} & {n2} = {n3}");
            */
            #endregion

            #region Code: 5-5
            /*
            int n1 = 5, n2 = 6, n3;

            n3 = n1 ^ n2;

            Console.WriteLine($"{n1} & {n2} = {n3}");
            */
            #endregion

            #region Code: 5-6
            /*
            int n = int.Parse(Console.ReadLine());

            if (Convert.ToBoolean(n & 1))
            {
                Console.WriteLine($"{n} is odd");
            }
            else
            {
                Console.WriteLine($"{n} is even");
            }
            */
            #endregion

            #region Code: 5-7
            /*
            string str = "AbCdEfGhIjKlMnOpQrStUvWxYz";

            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine($"Upprecase : {ToUpper(str[i])}, Lowercase : {ToLower(str[i])}");
            }
            */
            #endregion

            #region Code: 5-8
            /*
            int x = int.Parse(Console.ReadLine());

            if (x != 0 && Convert.ToBoolean(x & (x - 1)) == false)
            {
                Console.WriteLine($"{x} is a power of 2");
            }
            else
            {
                Console.WriteLine($"{x} is a NOT power of 2");
            }
            */
            #endregion

            #region Code: 5-8 Ex
            /*
            int num, binary, count = 0;

            Console.Write("Enter a decimal number: ");
            num = Convert.ToInt32(Console.ReadLine());
            binary = DecimalToBinary(num);
            Console.WriteLine("The Binary is: {0}", binary);
            
            string binaryToString = binary.ToString();

            for (int i = 0; i < binaryToString.Length; i++)
            {
                if (binaryToString[i] == '1')
                {
                    count++;
                }
            }

            Console.WriteLine($"Number of 1: {count}");
            */
            #endregion

            #region Code: 5-9
            /*
            int n, count = 0;

            Console.Write("Enter a decimal number: ");
            n = int.Parse(Console.ReadLine());

            while (Convert.ToBoolean(n))
            {
                if (Convert.ToBoolean(n & 1))
                {
                    count++;
                }

                n = n >> 1;
            }

            Console.WriteLine($"Number of 1: {count}");
            */
            #endregion

            #region Code: 5-10
            /*
            int n = 32, count = 0, num;

            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (Convert.ToBoolean(num & (1 << i)))
                {
                    count++;
                }
            }

            Console.WriteLine($"Number of 1: {count}");
            */
            #endregion

            #region Code: 5-11
            /*
            string[] line = Console.ReadLine().Split(' ');

            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);

            if (Convert.ToBoolean(n ^ m))
            {
                Console.WriteLine("Numbers are not equal");
            }
            else
            {
                Console.WriteLine("Numbers are equal");
            }
            */
            #endregion

            #region Code: 5-12
            /*
            int[] ara = { 1, 2, 3, 4, 1, 2, 3 };
            int result = ara[0];

            for (int i = 1; i < ara.Length; i++)
            {
                result = result ^ ara[i];
            }

            Console.WriteLine($"Result is: {result}");
            */
            #endregion
        }

        #region Function: 5-7
        /*
        static char ToUpper(char ch)
        {
            return Convert.ToChar(ch & 95);
        }

        static char ToLower(char ch)
        {
            return Convert.ToChar(ch | 32);
        }
        */
        #endregion

        #region Function: 5-8 Ex
        /*
        static int DecimalToBinary(int num)
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
