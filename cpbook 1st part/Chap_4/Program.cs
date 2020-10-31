using System;
using System.Runtime.InteropServices;

namespace Chap_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code: 4.1
            /*
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
            Console.WriteLine("10");
            */

            // Console.WriteLine("1\n2\n3\n4\n5\n6\n7\n8\n9\n10");
            #endregion

            #region Code: 4.2
            /*
            int n = 1;

            while (n <= 10)
            {
                Console.WriteLine("{0}", n);
                n++;
            }
            */
            #endregion

            #region Code: 4.3
            /*
            int n = 1;

            while (n <= 10)
            {
                Console.WriteLine("{0}", n);
            }

            n++;
            */
            #endregion

            #region Code: 4.4
            /*
            int n = 1;

            while (n <= 100)
            {
                Console.WriteLine("{0}", n);
                n++;

                if (n > 10)
                {
                    break;
                }
            }
            */
            #endregion

            #region Code: 4.5
            /*
            int n = 0;

            while (n < 10)
            {
                n = n + 1;

                if (n % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine("{0}", n);
            }
            */
            #endregion

            #region Code: 4.6
            /*
            int n = 5;
            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine("{0} X {1} = {2}", n, i, n * i);
                i = i + 1;
            }
            */
            #endregion

            #region Code: 4.7
            /*
            int n = 5;
            int i;

            for (i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine("{0} X {1} = {2}", n, i, n * i);
            }
            */

            /*
            int i = 1;

            for (; i <= 10; i = i + 1)
            {
                Console.WriteLine("{0} X {1} = {2}", n, i, n * i);
            }
            */
            #endregion

            #region Code: 4.8
            /*
            int n = 5;
            int i = 1;

            for ( ; ; )
            {
                Console.WriteLine("{0} X {1} = {2}", n, i, n * i);
                i = i + 1;

                if (i > 10)
                {
                    break;
                }
            }
            */
            #endregion

            #region Code: 4.9
            /*
            int m, n = 5;
            int i;

            m = 0;

            for (i = 1; i <= 10; i = i + 1)
            {
                m = m + n;
                Console.WriteLine("{0} X {1} = {2}", n, i, m);
            }
            */
            #endregion

            #region Code: 4.10
            /*
            int n, i;

            for (n = 1; n <= 20; n = n + 1)
            {
                for (i = 1; i <= 10; i = i + 1)
                {
                    Console.WriteLine("{0} X {1} = {2}", n, i, n * i);
                }
            }
            */
            #endregion

            #region Code: 4.10 Ex
            /*
            int m, n, i;

            for (n = 1; n <= 20; n = n + 1)
            {
                m = 0;
                for (i = 1; i <= 10; i = i + 1)
                {
                    m = m + n;
                    Console.WriteLine("{0} X {1} = {2}", n, i, m);
                }
            }
            */
            #endregion

            #region Code: 4.11
            /*
            int a, b, c;

            for (a = 1; a <= 3; a++)
            {
                for (b = 1; b <= 3; b++)
                {
                    for (c = 1; c <= 3; c++)
                    {
                        Console.WriteLine("{0}, {1}, {2}", a, b, c);
                    }
                }
            }
            */
            #endregion

            #region Code: 4.12
            /*
            int a, b, c;

            for (a = 1; a <= 3; a++)
            {
                for (b = 1; b <= 3 && b != a; b++)
                {
                    for (c = 1; c <= 3 && c != a && c != b; c++)
                    {
                        Console.WriteLine("{0}, {1}, {2}", a, b, c);
                    }
                }
            }
            */
            #endregion

            #region Code: 4.13
            /*
            int a, b, c;

            for (a = 1; a <= 3; a++)
            {
                for (b = 1; b <= 3; b++)
                {
                    if (b != a)
                    {
                        for (c = 1; c <= 3; c++)
                        {
                            if (c != b & c != a)
                            {
                                Console.WriteLine("{0}, {1}, {2}", a, b, c);
                            }
                        }
                    }
                }
            }
            */
            #endregion

            #region Code: 4.14
            /*
            int a, b, c;

            for (a = 1; a <= 3; a++)
            {
                for (b = 1; b <= 3; b++)
                {
                    for (c = 1; c <= 3; c++)
                    {
                        if (a != b && b != c && c != a)
                        {
                            Console.WriteLine("{0}, {1}, {2}", a, b, c);
                        }
                    }
                }
            }
            */
            #endregion
        }
    }
}
