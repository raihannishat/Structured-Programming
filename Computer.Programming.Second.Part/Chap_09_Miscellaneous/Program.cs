using System;
using System.IO;

namespace Chap_09_Miscellaneous
{
    /*
    public unsafe struct IP
    {
        public int* ip;
    }

    public struct A100
    {
        int[] ara;
    }

    public struct FP
    {
        FileAccess fileAccess; 
    }
    */

    unsafe class Program
    {
        #region Code: 9-1
        /*
        const int MIN = -1;
        static double PI = 2 * (Math.Acos(0));

        static void Main(string[] args)
        {
            Console.WriteLine($"Value of MIN : {MIN}");
            Console.WriteLine($"Value of PI : {PI}");
        }
        */
        #endregion

        #region Code: 9-2
        /*
        const int p = 50;
        const int q = 60;

        static void Main(string[] args)
        {
            int a = p;
            int b = q;

            Console.WriteLine($"a = {a}, b = {b}");
        }
        */
        #endregion

        #region Code: 9-3
        /*
        static void Main(string[] args)
        {
            int a = 83, b = 323;
            double d1 = 8.32323, d2 = 3.33332323;

            Console.WriteLine($"maximum of {a} and {b} is {MAX(a, b)}");
            Console.WriteLine($"maximum of {d1} and {d2} is {MAX(d1, d2)}");
        }
        */
        #endregion

        #region Code: 9-4
        /*
        static void Main(string[] args)
        {
            dynamic a = 83, b = 323;

            Console.WriteLine($"a = {a}, b = {b}");
            SWAP(ref a, ref b);
            Console.WriteLine($"a = {a}, b = {b}");
        }
        */
        #endregion

        #region Code: 9-5
        /*
        static void Main(string[] args)
        {
            COLOR select_color;
            int num;

            Console.Write($"Enter 1 for RED, 2 for GREEN, 3 for BLUE: ");
            num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                select_color = COLOR.RED;
            }
            else if (num == 2)
            {
                select_color = COLOR.GREEN;
            }
            else
            {
                select_color = COLOR.BLUE;
            }

            Console.WriteLine($"select_color : {select_color}");
        }
        */
        #endregion

        #region Code: 9-6
        /*
        static void Main(string[] args)
        {
            Console.WriteLine($"value : {(int) COLOR.NO_COLOR}");
            Console.WriteLine($"value : {(int) COLOR.RED}");
            Console.WriteLine($"value : {(int) COLOR.GREEN}");
            Console.WriteLine($"value : {(int) COLOR.BLUE}");
        }
        */
        #endregion

        #region Code: 9-7
        /*
        static void Main(string[] args)
        {
            Console.WriteLine($"value : {(int)COLOR.NO_COLOR}");
            Console.WriteLine($"value : {(int)COLOR.RED}");
            Console.WriteLine($"value : {(int)COLOR.GREEN}");
            Console.WriteLine($"value : {(int)COLOR.BLUE}");
        }
        */
        #endregion

        #region Code: 9-8
        /*
        static void Main(string[] args)
        {
            DAY today = DAY.THURSDAY;

            switch (today)
            {
                case DAY.SUNDAY:
                    Console.WriteLine("Today is Sunday. It is a work day");
                    break;
                case DAY.MONDAY:
                    Console.WriteLine("Today is Monday. It is a work day");
                    break;
                case DAY.TUESDAY:
                    Console.WriteLine("Today is Tuesday. It is a work day");
                    break;
                case DAY.WEDNESDAY:
                    Console.WriteLine("Today is Wednesday. It is a work day");
                    break;
                case DAY.THURSDAY:
                    Console.WriteLine("Today is Thursday. It is a work day");
                    break;
                case DAY.FRIDAY:
                    Console.WriteLine("Today is Friday. It is a work day");
                    break;
                case DAY.SATURDAY:
                    Console.WriteLine("Today is Saturday. It is a work day");
                    break;
            }
        }
        */
        #endregion

        #region Code: 9-9
        /*
        static void Main(string[] args)
        {
            Console.Write($"Enter a positive integer (> 0): ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("One item");
                    break;
                case 2:
                    Console.WriteLine("Two item");
                    break;
                default:
                    Console.WriteLine("Many item");
                    break;
            }
        }
        */
        #endregion

        #region Code: 9-10
        /*
        static void Main(string[] args)
        {
            int n1, n2, sum;

            n1 = int.Parse(args[0]);
            n2 = int.Parse(args[1]);

            sum = n1 + n2;

            Console.WriteLine($"{n1} + {n2} = {sum}");
        }
        */
        #endregion

        #region Code: 9-11
        /*
        static void Main(string[] args)
        {
            Console.WriteLine($"Argument count {args.Length}");
            Console.WriteLine($"First argument {args[0]}");
        }
        */
        #endregion

        #region Code: 9-12
        /*
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.Write("Plese enter one argument (your name): ");
            }

            Console.WriteLine($"Welcome {args[0]}");
        }
        */
        #endregion

        #region Code: 9-13
        /*
        static void Main(string[] args)
        {
            int* a;
            IP b;
            IP c, d;
        }
        */
        #endregion

        #region Code: 9-14
        /*
        static void Main(string[] args)
        {
            int* a;
            int* b;
            int* c, d;
        }
        */
        #endregion

        #region Code: 9-15
        /*
        static void Main(string[] args)
        {
            int* a;
            IP b;
            IP c, d;
        }
        */
        #endregion

        #region Code: 9-16
        /*
        static void Main(string[] args)
        {
            int a, b, c;
            A100 a100, p, q;
            FP f1, f2;
        }
        */
        #endregion

        #region Code: 9-17
        /*
        static void Main(string[] args)
        {
            int a;
            a = 2;
            3 = a;
        }
        */
        #endregion

        #region Code: 9-18
        /*
        static void Main(string[] args)
        {
            int a, b;
            enum color { RED, GREEN, BLUE }
            color c;
            a = 4;
            b = 2;
            4 = a;
            (a + 2) = 3;
            b = (a + 2);
            a + b = a - b;
            c = color.RED;
            green = c
        }
        */
        #endregion

        #region Function: 9-3
        /*
        static dynamic MAX(dynamic a, dynamic b)
        {
            return a > b ? a : b;
        }
        */
        #endregion

        #region Function: 9-4
        /*
        static void SWAP(ref dynamic a, ref dynamic b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        */
        #endregion
    }

    #region Enum: 9-5
    // enum COLOR { RED, GREEN, BLUE }
    #endregion

    #region Enum: 9-6
    // enum COLOR { NO_COLOR, RED, GREEN, BLUE }
    #endregion

    #region Enum: 9-7
    // enum COLOR { NO_COLOR = 0, RED = 40, GREEN = 44, BLUE = 60 }
    #endregion

    #region Enum: 9-8
    /*
    enum DAY
    {
        SUNDAY,
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY
    }
    */
    #endregion
}
