using System;

namespace Chap_02_Pointer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code: 2-1
            /*
            unsafe
            {
                int x = 10;
                int* pointerOfx = &x;

                Console.WriteLine($"Value of x is {x}");
                Console.WriteLine($"Address of x is {(long)pointerOfx:X}");
            }
            */
            #endregion

            #region Code: 2-2
            /*
            unsafe
            {
                int x = 10;
                int* p;

                p = &x;

                Console.WriteLine($"*p = {*p}");
                Console.WriteLine($"Value of p is {(long)p:X}");
            }
            */
            #endregion

            #region Code: 2-3
            /*
            unsafe
            {
                double pi = 3.14159265358;

                int* ptr;
                ptr = &pi;

                Console.WriteLine($"Value of pi : {pi}");
                Console.WriteLine($"Value of pi : {*ptr}");
            }
            */
            #endregion

            #region Code: 2-4
            /*
            unsafe
            {
                int x = 10;
                int* p;

                p = &x;
                Console.WriteLine($"Value of x: {x}");

                *p = 20;
                Console.WriteLine($"Value of x: {x}");
                Console.WriteLine($"Address of x: {(long)p:X}");
                Console.WriteLine($"Value of p: {(long)p:X}");
            }
            */
            #endregion

            #region Code: 2-5
            /*
            unsafe
            {
                int x = 10;
                int* p;

                Console.WriteLine($"Value of x: {x}");

                p = &x;
                *p = 20;

                Console.WriteLine($"Value of x: {x}");

                x = 15;

                Console.WriteLine($"Value of x: {x}");
                Console.WriteLine($"Value stord at location {(long)p:X} is {*p}");

                Console.WriteLine($"Address of x: {(long)p:X}");
                Console.WriteLine($"Value of p: {(long)p:X}");
            }
            */
            #endregion

            #region Code: 2-6
            /*
            unsafe
            {
                int x = 10;
                int y;
                int* p;
                int* z;

                Console.WriteLine($"Value of x: {x}");

                p = &x;
                z = &y;
                y = *p;
                *p = 15;

                Console.WriteLine($"Value of x: {x}");
                Console.WriteLine($"Value of y: {y}");
                Console.WriteLine($"Value of *p: {*p}");
                Console.WriteLine($"Address of x: {(long)p:X}");
                Console.WriteLine($"Address of y: {(long)z:X}");
                Console.WriteLine($"Value of p: {(long)p:X}");
            }
            */
            #endregion

            #region Code: 2-7
            /*
            unsafe
            {
                int x = 10, y;
                int* p, q;

                p = &x;
                y = *p;
                *p = 15;
                *q = 20;

                Console.WriteLine($"Value of x: {x}");
                Console.WriteLine($"Value of y: {y}");
                Console.WriteLine($"Value of *p: {*p}");
                Console.WriteLine($"Value of *q: {*q}");
            }
            */
            #endregion

            #region Code: 2-8
            /*
            unsafe
            {
                int x = 10, y;
                int* p, q;

                p = &x;
                q = &y;
                y = *p;
                *p = 15;
                *q = 20;

                Console.WriteLine($"Value of x: {x}");
                Console.WriteLine($"Value of y: {y}");
                Console.WriteLine($"Value of *p: {*p}");
                Console.WriteLine($"Value of *q: {*q}");
            }
            */
            #endregion

            #region Code: 2-9
            /*
            unsafe
            {
                int x = 100;
                int* p = null;

                Console.WriteLine($"Value of x: {x}");
                Console.WriteLine($"Value of *p: {*p}");
            }
            */
            #endregion

            #region Code: 2-10
            /*
            unsafe
            {
                int x = 100;
                int* p = null;

                Console.WriteLine($"Value of x: {x}");
                p = &x;
                Console.WriteLine($"Value of *p: {*p}");
            }
            */
            #endregion

            #region Code: 2-11
            /*
            unsafe
            {
                int* p = null;
                *p = 100;
                Console.WriteLine($"Value of *p: {*p}");
            }
            */
            #endregion

            #region Code: 2-12
            /*
            unsafe
            {
                string s = "Bangladesh";

                fixed (char* p = s)
                {
                    Console.WriteLine($"Name of our country : {s}");
                    Console.WriteLine($"Address of s : {(long)p:X}");
                }

                https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/unsafe-code-pointers/pointer-types
            }
            */
            #endregion

            #region Code: 2-13
            /*
            unsafe
            {
                string s = "Bangladesh";

                fixed (char* p = s)
                {
                    Console.WriteLine($"Name of our country : {*p}");
                }
            */
            #endregion

            #region Code: 2-14
            /*
            unsafe
            {
                char c1 = 'A', c2 = 'B', c3 = 'C';
                char* p1, p2, p3;

                p3 = &c3;
                p2 = &c2;
                p1 = &c1;

                Console.WriteLine($"{*p1}, {*p2}, {*p3}");
            }
            */
            #endregion

            #region Code: 2-15
            /*
            unsafe
            {
                char c = 'A';
                char* p;
                char** q;

                p = &c;
                q = &p;

                Console.WriteLine($"Address of c : {(long)p:X}");
                Console.WriteLine($"Address of p : {(long)q:X}");
            }
            */
            #endregion

            #region Code: 2-16
            /*
            unsafe
            {
                char c = 'A';
                char* p;
                char** q;

                p = &c;
                q = &p;

                Console.WriteLine($"Value of c : {c}");
                Console.WriteLine($"Value of c : {*p}");
                Console.WriteLine($"Value of c : {**q}");
            }
            */
            #endregion

            #region Code: 2-17
            /*
            unsafe
            {
                char c = 'A';
                char* p;
                char** q;

                p = &c;
                q = &p;

                **q = 'B';

                Console.WriteLine($"Value of c : {c}");
                Console.WriteLine($"Value of c : {*p}");
                Console.WriteLine($"Value of c : {**q}");
            }
            */
            #endregion
        }
    }
}
