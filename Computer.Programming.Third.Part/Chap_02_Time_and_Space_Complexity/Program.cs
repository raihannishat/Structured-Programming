using System;

namespace Chap_02_Time_and_Space_Complexity
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code: 2-1
            /*
            int n1, n2, result;

            n1 = 10;
            n2 = 20;

            result = n1 + n2;
            */
            #endregion

            #region Code: 2-2
            /*
            int n, result;

            n = int.Parse(Console.ReadLine());

            result = n * (n + 1) / 2;

            Console.WriteLine($"result = {result}");
            */
            #endregion

            #region Code: 2-3
            /*
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} is even number");
            }
            else
            {
                Console.WriteLine($"{n} is odd number");
            }
            */
            #endregion

            #region Code: 2-4
            /*
            int[] even = new int[101];

            for (int i = 0; i < 101; i++)
            {
                even[i] = 0;
            }

            for (int i = 0; i < 101; i += 2)
            {
                even[i] = 1;
            }

            int n = int.Parse(Console.ReadLine());

            if (Convert.ToBoolean(even[n]))
            {
                Console.WriteLine($"{n} is even number");
            }
            else
            {
                Console.WriteLine($"{n} is odd number");
            }
            */
            #endregion

            #region Code: 2-5
            /*
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    count = count + 1;
                }
            }

            Console.WriteLine($"n = {n}, count = {count}");
            */
            #endregion

            #region Code: 2-6
            /*
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                count = count + 1;
            }

            Console.WriteLine($"n = {n}, count = {count}");
            */
            #endregion

            #region Code: 2-7
            /*
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        count = count + 1;
                    }
                }
            }

            Console.WriteLine($"n = {n}, count = {count}");
            */
            #endregion

            #region Code: 2-8
            /*
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    count = count + 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                count = count + 1;
            }

            Console.WriteLine($"n = {n}, count = {count}");
            */
            #endregion
        }
    }
}
