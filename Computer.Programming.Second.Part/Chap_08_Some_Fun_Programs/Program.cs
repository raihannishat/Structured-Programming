using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap_08_Some_Fun_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code: 8-1
            /*
            int x = 0, n = 12345678;
            DateTime start_time, end_time;
            TimeSpan time_elapsed;

            start_time = DateTime.Now;

            for (int i = 0; i < 1000000000; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    x = n * 2;
                }
            }

            end_time = DateTime.Now;

            time_elapsed = end_time - start_time;

            Console.WriteLine($"Time: {time_elapsed}");

            start_time = DateTime.Now;

            for (int i = 0; i < 1000000000; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    fnc(x, n);
                }
            }

            end_time = DateTime.Now;

            time_elapsed = end_time - start_time;

            Console.WriteLine($"Time: {time_elapsed}");
            */
            #endregion

            #region Code: 8-2
            /*
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random.Next(5));
            }
            */
            #endregion

            #region Code: 8-3
            /*
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random.Next(-1, 1));
            }
            */
            #endregion

            #region Code: 8-4
            /*
            var random = new Random();
            var possibilities = Enumerable.Range(1, 5).ToList();
            var result = possibilities.OrderBy(number => random.Next()).Take(5).ToArray();
            Array.ForEach(result, item => Console.Write($"{item} "));
            Console.WriteLine();
            */
            #endregion

            #region Code: 8-4 Ex
            /*
            Console.Write("Minimun value : ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Maximum value : ");
            int max = int.Parse(Console.ReadLine());

            var random = new Random();
            var possibilities = Enumerable.Range(min, max).ToList();
            var result = possibilities.OrderBy(number => random.Next()).Take(max).ToArray();
            Array.ForEach(result, item => Console.Write($"{item} "));
            Console.WriteLine();
            */
            #endregion

            #region Code: 8-5
            // Dimik.cs
            #endregion

            #region Code: 8-6
            /*
            int n1 = 10, n2 = 5;

            Console.WriteLine($"{n1} + {n2} = {Dimik.add(n1, n2)}");
            Console.WriteLine($"{n1} * {n2} = {Dimik.mul(n1, n2)}");
            */
            #endregion
        }

        #region Function: 8-1
        /*
        static void fnc(int x, int n)
        {
            x = n * 2;
        }
        */
        #endregion 
    }
}
