using System;
using System.Collections.Generic;

namespace Chap_04_Recursion
{
    class Program
    {
        // static int x = 1;
        // static int a;
        // static int b;
        // static int s = 10;
        // static int count = 1;
        // static int f_calls = 0;
        // static int[] fibo = new int[50];
        #region Code: 4-1
        /*
        int x;
        static void Main(string[] args)
        {
            int y;

            Console.WriteLine($"x = {x}, y = {y}");
        }
        */
        #endregion

        #region Code: 4-2
        /*
        static void myfnc(int y)
        {
            y = y * 2;
            x = x + 10;
            Console.WriteLine($"myfnc, x = {x}, y = {y}");
        }

        static void Main(string[] args)
        {
            int y = 5;

            x = 10;

            myfnc(y);

            Console.WriteLine($"main, x = {x}, y = {y}");
        }
        */
        #endregion

        #region Code: 4-3
        /*
        static void func()
        {
            a = a + 1;
            b = b + 1;
        }

        static void Main(string[] args)
        {
            func();
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
        */
        #endregion

        #region Code: 4-4
        /*
        static void func()
        {
            int a = 10;

            a = a + 2;
            s = s + 2;

            Console.WriteLine($"a = {a}, s = {s}");
        }

        static void Main(string[] args)
        {
            func();
            func();
            func();
        }
        */
        #endregion

        #region Code: 4-5
        /*
        static void recurse()
        {
            string s = "Hurrey, I am learning recursion!";
            Console.WriteLine($"{s}");
            recurse();
        }

        static void Main(string[] args)
        {
            recurse();
        }
        */
        #endregion

        #region Code: 4-6
        /*
        static void recurse(int count)
        {
            if (count == 5)
            {
                return;
            }

            Console.WriteLine("I am learning recursion.");
            recurse(count + 1);
            return;
        }

        static void Main(string[] args)
        {
            recurse(1);
        }
        */
        #endregion

        #region Code: 4-7
        /*
        static void recurse(int count)
        {
            if (count > 5)
            {
                return;
            }

            Console.WriteLine($"Count = {count}");
            recurse(count + 1);
        }

        static void Main(string[] args)
        {
            recurse(1);
        }
        */
        #endregion

        #region Code: 4-8
        /*
        static void recurse(int count)
        {
            if (count > 5)
            {
                return;
            }

            recurse(count + 1);
            Console.WriteLine($"Count = {count}"); 
        }

        static void Main(string[] args)
        {
            recurse(1);
        }
        */
        #endregion

        #region Code: 4-9
        /*
        static void recurse(int count)
        {
            if (count > 5)
            {
                return;
            }

            Console.WriteLine($"Count = {count}");
            recurse(count + 1);
            Console.WriteLine($"Count = {count}");
        }

        static void Main(string[] args)
        {
            recurse(1);
        }
        */
        #endregion

        #region Code: 4-10
        /*
        static void recurse()
        {
            if (count > 5)
            {
                return;
            }

            Console.WriteLine($"Count = {count}");
            count = count + 1;
            recurse();
        }

        static void Main(string[] args)
        {
            recurse();
        }
        */
        #endregion

        #region Code: 4-11
        /*
        static int factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * factorial(n - 1);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Undefined");
            }

            Console.WriteLine($"Factorial of {n} is {factorial(n)}");
        }
        */
        #endregion

        #region Code: 4-12
        /*
        static int factorial(int n)
        {
            f_calls = f_calls + 1;

            if (n == 0)
            {
                return 1;
            }

            return n * factorial(n - 1);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Undefined");
            }

            Console.WriteLine($"Factorial of {n} is {factorial(n)}");

            Console.WriteLine($"Number of function calls : {f_calls}");
        }
        */
        #endregion

        #region Code: 4-13
        /*
        static int fib(int n)
        {
            f_calls = f_calls + 1;

            if (n == 1 || n == 2)
            {
                return 1;
            }

            return fib(n - 1) + fib(n - 2);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s;

            if (n == 1)
            {
                s = new String("st");
            }
            else if (n == 2)
            {
                s = new String("nd");
            }
            else if (n == 3)
            {
                s = new String("rd");
            }
            else
            {
                s = new String("th");
            }

            Console.WriteLine($"{n}{s} fibonacci number is {fib(n)}");

            Console.WriteLine($"Number of function calls : {f_calls}");
        }
        */
        #endregion

        #region Code: 4-14
        /*
        static int fib(int n)
        {
            f_calls = f_calls + 1;

            if (fibo[n] != 0)
            {
                return fibo[n];
            }

            if (n == 1 || n == 2)
            {
                return fibo[n];
            }

            fibo[n] = fib(n - 1) + fib(n - 2);

            return fibo[n];
        }

        static void Main(string[] args)
        {
            int n;
            string s;

            fibo[1] = 1;
            fibo[2] = 1;

            n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                s = new String("st");
            }
            else if (n == 2)
            {
                s = new String("nd");
            }
            else if (n == 3)
            {
                s = new String("rd");
            }
            else
            {
                s = new String("th");
            }

            Console.WriteLine($"{n}{s} fibonacci number is {fib(n)}");

            Console.WriteLine($"Number of function calls : {f_calls}");

            for (n = 0; n < 12; n++)
            {
                Console.WriteLine($"{n} {fibo[n]}");
            }
        }
        */
        #endregion

        #region Ex - 1
        /*
        static int Sum(int value)
        {
            if (value != 0)
            {
                return value + Sum(value - 1);
            }

            return value;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"The sum is {sum(int.Parse(Console.ReadLine()))}");
        }
        */
        #endregion

        #region Ex - 2
        /*
        static void revers(string str)
        {
            if (str.Length == 0)
            {
                return;
            }

            revers(str.Substring(1));
            Console.Write(str[0]);
        }

        static void Main(string[] args)
        {
            revers(Console.ReadLine());
        }
        */
        #endregion

        #region Ex - 3
        /*
        static IList<IList<int>> Permute(int[] nums)
        {
            var list = new List<IList<int>>();
            return DoPermute(nums, 0, nums.Length - 1, list);
        }

        static IList<IList<int>> DoPermute(int[] nums, int start, int end, IList<IList<int>> list)
        {
            if (start == end)
            {
                // We have one of our possible n! solutions,
                // add it to the list.
                list.Add(new List<int>(nums));
            }
            else
            {
                for (var i = start; i <= end; i++)
                {
                    Swap(ref nums[start], ref nums[i]);
                    DoPermute(nums, start + 1, end, list);
                    Swap(ref nums[start], ref nums[i]);
                }
            }

            return list;
        }

        static void PrintResult(IList<IList<int>> lists)
        {
            foreach (var list in lists)
            {
                Console.WriteLine($"[{string.Join(',', list)}]");
            }
        }

        static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3};

            PrintResult(Permute(array));
        }
        */
        #endregion
    }
}
