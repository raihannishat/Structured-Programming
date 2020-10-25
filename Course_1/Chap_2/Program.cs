using System;

namespace Chap_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a;
            int b;
            int sum;

            a = 50;
            b = 60;

            sum = a + b;

            Console.WriteLine("Sum is {0}", sum);
            */

            /*
            int a, b, sum;

            a = 50;
            b = 60;

            sum = a + b;

            Console.WriteLine("Sum is {0}", sum);
            */

            /*
            int a = 50, b = 60, sum;

            sum = a + b;

            Console.WriteLine("Sum is {0}", sum);
            */

            /*
            int x, y;

            x = 1;
            y = x;
            x = 2;

            Console.WriteLine("{0}", y);
            */

            /*
            int a = 50, b = 60, sum;

            sum = a + b;

            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
            */

            /*
            int a = 50.45, b = 60, sum;

            sum = a + b;

            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
            */

            /*
            int n;
            double x;

            x = 10.5;
            n = (int)x;

            Console.WriteLine("Value of n is {0}", n);
            Console.WriteLine("Value of x is {0}", x);
            */

            /*
            int a;

            a = 1000;
            Console.WriteLine("Value of a is {0}", a);

            a = -21000;
            Console.WriteLine("Value of a is {0}", a);

            a = 10000000;
            Console.WriteLine("Value of a is {0}", a);

            a = -10000000;
            Console.WriteLine("Value of a is {0}", a);

            a = 100020004000503;
            Console.WriteLine("Value of a is {0}", a);

            a = -4325987632;
            Console.WriteLine("Value of a is {0}", a);
            */

            /*
            double a, b, sum;

            a = 9.5;
            b = 8.743;

            sum = a + b;

            Console.WriteLine("1st: Sum is {0}", sum);

            Console.WriteLine("2nd: Sum is {0:0.##}", sum);
            */

            /*
            int a, b, sum;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;

            Console.WriteLine("Sum is {0}", sum);
            */

            /*
            char ch;

            Console.Write("Enter the first letter of your name: ");

            ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("The first letter of your name: {0}", ch);
            */

            /*
            int num1, num2;

            Console.Write("Please enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            */

            /*
            int num1, num2, value;
            char sign;

            Console.Write("Please enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            value = num1 + num2;
            sign = '+';
            Console.WriteLine("{0} {1} {2} = {3}", num1, sign, num2, value);

            value = num1 - num2;
            sign = '-';
            Console.WriteLine("{0} {1} {2} = {3}", num1, sign, num2, value);

            value = num1 * num2;
            sign = '*';
            Console.WriteLine("{0} {1} {2} = {3}", num1, sign, num2, value);

            value = num1 / num2;
            sign = '/';
            Console.WriteLine("{0} {1} {2} = {3}", num1, sign, num2, value);
            */

            // test program - comment 1

            Console.Write("Hello ");

            /* We have printed Hello,
             * now we shall print World
             * Note that this is a multi-line comment
             */

            Console.WriteLine("World"); // printed world
        }
    }
}
