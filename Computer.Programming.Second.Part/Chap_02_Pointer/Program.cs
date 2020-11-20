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
            #endregion
        }
    }
}
