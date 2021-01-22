using System;

namespace Chap_10_Program_Debugging
{
    class Program
    {
        const bool DEBUG = false;

        static void Main(string[] args)
        {
            #region Code: 10-1
            /*
            int length, sum = 0, temp;

            Console.Write($"Enter number of integers: ");
            length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                temp = int.Parse(Console.ReadLine());
                sum = add(sum, temp);
            }

            Console.WriteLine($"The avarage is {(double)(sum / length):0.00}");
            */
            #endregion

            #region Code: 10-2
            /*
            int length, sum = 0, temp;

            Console.Write($"Enter number of integers: ");
            length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                temp = int.Parse(Console.ReadLine());
                Console.WriteLine($"Number {i + 1} = {temp}");
                sum = add(sum, temp);
            }

            Console.WriteLine($"The avarage is {(double)(sum / length):0.00}");
            */
            #endregion

            #region Code: 10-3
            /*
            int length, sum = 0, temp;

            Console.Write($"Enter number of integers: ");
            length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                temp = int.Parse(Console.ReadLine());
                sum = add(sum, temp);
                Console.WriteLine($"Current Number is = {temp}, Current Sum = {sum}");
            }

            Console.WriteLine($"The avarage is {(double)sum / length:0.00}");
            */
            #endregion

            #region Code: 10-4
            /*
            int length, sum = 0, temp;

            Console.Write($"Enter number of integers: ");
            length = int.Parse(Console.ReadLine());

            if (DEBUG) Console.WriteLine($"----\nDEBUG\n\tNumber of integers: {length}\nENDDEBUG\n----\n");

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                temp = int.Parse(Console.ReadLine());

                if (DEBUG) Console.WriteLine($"----\nDEBUG\n\tNumber {i + 1} : {temp}\nENDDEBUG\n----\n");

                sum = add(sum, temp);
                if (DEBUG) Console.WriteLine($"----\nDEBUG\n\tCurrent Sum: {sum}\nENDDEBUG\n----\n");
            }

            Console.WriteLine($"The avarage is {(double)sum / length:0.00}");
            */
            #endregion

            #region Code: 10-5
            /*
            int length, sum = 0;
            int[] array;

            Console.Write($"Enter number of integers: ");
            length = int.Parse(Console.ReadLine());
            array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
                sum = add(sum, array[i]);
            }

            Console.WriteLine($"The avarage is {(double)sum / length:0.00}");
            */
            #endregion
        }

        #region Function: 10-1
        /*
        static int add(int a, int b)
        {
            return a * b;
        }
        */
        #endregion

        #region Function: 10-4
        /*
        static int add(int a, int b)
        {
            return a + b;
        }
        */
        #endregion
    }
}
