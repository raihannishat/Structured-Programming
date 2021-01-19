using System;
using System.Runtime.InteropServices;

namespace Chap_07_More_Pointer
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            #region Code: 7-1
            /*
            int* marks; 
            Console.Write($"Please enter the number of student: ");
            int n = int.Parse(Console.ReadLine());

            marks = (int*) Marshal.AllocHGlobal(sizeof(int) * n);

            Console.WriteLine($"Enter the marks for each student: ");
            for (int i = 0; i < n; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Print now here you can see the value");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{marks[i]}");
            }
            */
            #endregion

            #region Code: 7-2
            /*
            int* marks;
            Console.Write($"Please enter the number of student: ");
            int n = int.Parse(Console.ReadLine());

            marks = (int*)Marshal.AllocHGlobal(sizeof(int) * n);
            if (marks == null)
            {
                Console.WriteLine($"Memory allocation failed for marks");
            }

            Console.WriteLine($"Enter the marks for each student: ");
            for (int i = 0; i < n; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Print now here you can see the value");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{marks[i]}");
            }

            Marshal.FreeHGlobal((IntPtr)marks);
            */
            #endregion

            #region Code: 7-3
            /*
            int[][] ara = new int[5][];
            int[] num = new int[5];
            int n;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter the number of students for class {i + 1} : ");
                n = int.Parse(Console.ReadLine());
                ara[i] = new int[n];

                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Enter marks for student {j + 1} : ");
                    ara[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // now print the results
            Console.WriteLine("Output");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Class {i + 1} : ");

                for (int j = 0; j < ara[i].Length; j++)
                {
                    Console.Write($"\t{ara[i][j]}");
                }

                Console.WriteLine();
            }
            */
            #endregion

            #region Code: 7-4
            /*
            int[] num = new int[12];
            int total_classes, n;

            Console.Write($"Enter the total number of classes : ");
            total_classes = int.Parse(Console.ReadLine());
            int[][] ara = new int[total_classes][];
            Console.WriteLine();

            for (int i = 0; i < total_classes; i++)
            {
                Console.Write($"Enter the number of students for class {i + 1} : ");
                n = int.Parse(Console.ReadLine());
                ara[i] = new int[n];

                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Enter marks for student {j + 1} : ");
                    ara[i][j] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();
            }

            // now print the results
            Console.WriteLine("Output");

            for (int i = 0; i < ara.Length; i++)
            {
                Console.Write($"Class {i + 1} : ");

                for (int j = 0; j < ara[i].Length; j++)
                {
                    Console.Write($"\t{ara[i][j]}");
                }

                Console.WriteLine();
            }
            */
            #endregion

            #region Code: 7-5
            /*
            int[] ara = new int[] { 100, 300, 500, 700, 900 };
            
            fixed (int* p = ara)
            {
                Console.WriteLine($"*p : {*p}");
                Console.WriteLine($"*p + 1: {*p + 1}");
                Console.WriteLine($"*(p + 1): {*(p + 1)}");
                Console.WriteLine($"*p + 2: {*p + 2}");
                Console.WriteLine($"*(p + 2): {*(p + 2)}");
            }
            */
            #endregion

            #region Code: 7-6
            /*
            string str = "Bangladesh";

            fixed (char* p = str)
            {
                Console.WriteLine($"{*p}, {*(p + 1)}, {*(p + 2)}, {*(p + 3)}");
                Console.WriteLine($"{*p}, {Convert.ToChar(*p + 1)}, {Convert.ToChar(*p + 2)}, {Convert.ToChar(*p + 3)}");
            }
            */
            #endregion

            #region Code: 7-7
            /*
            char* p;
            char a = 'F';

            int* q;
            int b = 10;

            double* r;
            double c = 302.64;

            p = &a;
            q = &b;
            r = &c;

            Console.WriteLine($"Size of char: {sizeof(char)} byte");
            Console.WriteLine($"p : {(long)p:X}");
            Console.WriteLine($"p + 1: {(long)p + 1:X}");
            Console.WriteLine($"p + 2: {(long)p + 2:X}\n");

            Console.WriteLine($"Size of int: {sizeof(int)} byte");
            Console.WriteLine($"q : {(long)q:X}");
            Console.WriteLine($"q + 1: {(long)q + 1:X}");
            Console.WriteLine($"q + 2: {(long)q + 2:X}\n");

            Console.WriteLine($"Size of double: {sizeof(double)} byte");
            Console.WriteLine($"r : {(long)r:X}");
            Console.WriteLine($"r + 1: {(long)r + 1:X}");
            Console.WriteLine($"r + 2: {(long)r + 2:X}\n");
            */
            #endregion

            #region Code: 7-8
            /*
            void* vp;
            int n = 10;
            
            vp = &n;

            Console.WriteLine($"Adderss of n: {(long)vp:X}");
            Console.WriteLine($"Value of vp: {(long)vp}");
            Console.WriteLine($"Content of vp: {*((int*)vp)}");
            */
            #endregion

            #region Code: 7-9
            /*
            Func<int, int, int> fnc;

            int n1 = 10, n2 = 5;

            fnc = Add;

            Console.WriteLine($"Result : {fnc.Invoke(n1, n2)}");

            fnc = Sub;

            Console.WriteLine($"Result : {fnc.Invoke(n1, n2)}");
            */
            #endregion

            #region Code: 7-10
            /*
            int n1 = 10, n2 = 5;

            Console.WriteLine($"Result : {Operator(Add, n1, n2)}");

            Console.WriteLine($"Result : {Operator(Sub, n1, n2)}");
            */
            #endregion
        }

        #region Function: 7-9
        /*
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        static int Sub(int n1, int n2)
        {
            return n1 - n2;
        }
        */
        #endregion

        #region Function: 7-10
        /*
        public delegate int Fnc(int x, int y);

        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        static int Sub(int n1, int n2)
        {
            return n1 - n2;
        }

        static int Operator(Fnc fnc, int a, int b)
        {
            return fnc.Invoke(a, b);
        }
        */
        #endregion
    }
}
