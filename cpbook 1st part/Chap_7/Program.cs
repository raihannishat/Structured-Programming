using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Chap_7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Function Demo
            /*
            return_type function_name (parameters)
            {
                function_body
                return value
            }
            */
            #endregion

            #region Code: 7.1
            /*
            double a, b, c;
            a = 2.5;
            b = 2.5;
            c = a + b;
            Console.WriteLine("{0:0.00}", c);
            */
            #endregion

            #region Code: 7.2
            /*
            double a, b, c;
            a = b = 2.5;
            c = add(a, b);
            Console.WriteLine("{0:0.00}", c);
            */
            #endregion

            #region Code: 7.3
            /*
            double a, b, c;
            a = 2.8;
            b = 2.7;
            c = add(a, b);
            Console.WriteLine("{0:0.00}", c);
            */
            #endregion

            #region Code: 7.4
            /*
            double a, b, c;
            a = 2.8;
            b = 2.7;
            c = add(a, b);
            Console.WriteLine("{0:0.00}", c);
            */
            #endregion

            #region Code: 7.5
            /*
            double a = 2.8, b = 2.7, c;

            c = add(a, b);
            Console.WriteLine("{0:0.00}", c);
            */
            #endregion

            #region Code: 7.6
            /*
            int x = 10, y = 20, z = 30;
            z = test_function(x);
            Console.WriteLine("{0} {1} {2}", x, y, z);
            */
            #endregion

            #region Code: 7.7
            /*
            int[] ara = { -100, 0, 53, 22, 83, 23, 89, -132, 201, 3, 85 };
            int n = 11;
            int max = find_max(ara, n);
            Console.WriteLine("{0}", max);
            */
            #endregion

            #region Code: 7.8
            /*
            int[] ara = { 1, 2, 3, 4, 5 };
            Console.WriteLine("{0}", ara[0]);
            test_function(ara);
            Console.WriteLine("{0}", ara[0]);
            */
            #endregion

            #region Code: 7.8 Ex
            /*
            double a, r;
            r = Convert.ToDouble(Console.ReadLine());
            a = area(r);
            Console.WriteLine("Area: {0:0.00}", a);
            */
            #endregion
        }

        #region Function: 7.2
        /*
        static int add(int num1, int num2)
        {
            double sum = num1 + num2;
            return (int)sum;
        }
        */
        #endregion

        #region Function: 7.3
        /*
        static double add(double n1, double n2)
        {
            double sum = n1 + n2;
            return sum;
        }
        */
        #endregion

        #region Function: 7.4
        /*
        static double add(double n1, double n2)
        {
            double sum = n1 + n2;
            return sum;
        }
        */
        #endregion

        #region Function: 7.5
        /*
        static double add(double n1, double n2)
        {
            double sum = n1 + n2;
            return sum;
        }
        */
        #endregion

        #region Function: 7.6
        /*
        static int test_function(int x)
        {
            int y = x;
            x = 2 * y;
            return (x * y);
        }
        */
        #endregion

        #region Function: 7.7
        /*
        static int find_max(int[] ara, int n)
        {
            int max = ara[0];
            int i;

            for (i = 1; i < n; i++)
            {
                if (ara[i] > max)
                {
                    max = ara[i];
                }
            }

            return max;
        }
        */
        #endregion

        #region Function: 7.7 Ex - 1
        /*
        static int find_min(int[] ara, int n)
        {
            int min = ara[0];
            int i;

            for (i = 1; i < n; i++)
            {
                if (ara[i] < min)
                {
                    min = ara[i];
                }
            }

            return min;
        }
        */
        #endregion

        #region Function: 7.7 Ex - 2
        /*
        static int find_ava(int[] ara, int n)
        {
            int ava = 0, sum = 0;

            for (int i = 0; i < ara.Length; i++)
            {
                sum = sum + ara[i];
            }

            ava = sum / ara.Length;

            return ava;
        }
        */
        #endregion

        #region Function: 7.8
        /*
        static void test_function(int[] ara)
        {
            ara[0] = 100;
            return;
        }
        */
        #endregion

        #region Function: 7.8 Ex
        /*
        static double area(double r)
        {
            double a = Math.PI * (r * r);
            return a;
        }
        */
        #endregion
    }
}
