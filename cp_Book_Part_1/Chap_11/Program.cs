using System;

namespace Chap_11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code: 11.1
            /*
            int[,] marks = 
            {
                { 80, 70, 92, 78, 58, 83, 85, 66, 99, 81 },
                { 75, 67, 55, 100, 91, 84, 79, 61, 90, 97 },
                { 98, 67, 75, 89, 81, 83, 80, 90, 88, 77 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            int col;

            for (col = 0; col < 10; col++)
            {
                marks[3, col] = (int) (marks[0, col] / 4.0 + marks[1, col] / 4.0 + marks[2, col] / 2.0);
                Console.WriteLine("Roll NO: {0}\tTotal Marks: {1}", col + 1, marks[3, col]);
            }
            */
            #endregion

            #region Code: 10.2
            /*
            int[,] namta = new int[10, 10];
            int row, col;

            for (row = 0; row < 10; row++)
            {
                for (col = 0; col < 10; col++)
                {
                    namta[row, col] = (row + 1) * (col + 1);
                }
            }

            for (row = 0; row < 10; row++)
            {
                for (col = 0; col < 10; col++)
                {
                    Console.WriteLine("{0} x {1} = {2}", row + 1, col + 1, namta[row, col]);
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region Code: 10.2 Ex
            /*
            int[,] namta = new int[10, 10];
            int row, col, sum = 0, even = 0, odd = 0;

            for (row = 0; row < 10; row++)
            {
                for (col = 0; col < 10; col++)
                {
                    namta[row, col] = (row + 1) * (col + 1);

                    if (namta[row, col] % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }

                    sum += namta[row, col];
                }
            }

            for (row = 0; row < 10; row++)
            {
                for (col = 0; col < 10; col++)
                {
                    Console.WriteLine("{0} x {1} = {2}", row + 1, col + 1, namta[row, col]);
                }
                
                Console.WriteLine();
            }

            Console.WriteLine("Even: {0}, Odd: {1}, Sum: {2}", even, odd, sum);
            */
            #endregion

            #region Code: 10.3
            
            #endregion
        }
    }
}
