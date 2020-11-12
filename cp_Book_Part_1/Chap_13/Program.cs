using System;

namespace Chap_13
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Picture: 13.1 Ex - 1
            /*
            int row, col, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (row = n; row >= 1; row--)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("c");
                }
                Console.WriteLine();
            }

            for (row = 2; row <= n; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("c");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region Picture: 13.2 Ex - 2
            /*
            int row, col, space, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (row = n; row >= 1; row--)
            {
                for (space = 1; space <= n - row; space++)
                {
                    Console.Write(" ");
                }
                for (col = 1; col <= (2 * row) - 1; col++)
                {
                    Console.Write("c");
                }
                Console.WriteLine();
            }

            for (row = 2; row <= n; row++)
            {
                for (space = 1; space <= n - row; space++)
                {
                    Console.Write(" ");
                }
                for (col = 1; col <= (2 * row) - 1; col++)
                {
                    Console.Write("c");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region Picture: 13.3 Ex - 3
            /*
            int row, col, space, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (row = n; row >= 1; row--)
            {
                for (space = 1; space <= n - row; space++)
                {
                    Console.Write(" ");
                }

                for (col = 1; col <= row; col++)
                {
                    Console.Write("c");
                }

                Console.WriteLine();
            }

            for (row = 2; row <= n; row++)
            {
                for (space = 1; space <= n - row; space++)
                {
                    Console.Write(" ");
                }

                for (col = 1; col <= row; col++)
                {
                    Console.Write("c");
                }

                Console.WriteLine();
            }
            */
            #endregion

            #region Picture: 13.4 Ex - 4
            /*
            int row, col, space, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (row = n; row >= 1; row--)
            {
                for (col = n; col >= row; col--)
                {
                    Console.Write("c");
                }

                for (space = 2; space <= row; space++)
                {
                    Console.Write(" ");
                }

                for (space = 2; space <= row; space++)
                {
                    Console.Write(" ");
                }

                for (col = n; col >= row; col--)
                {
                    Console.Write("c");
                }

                Console.WriteLine();
            }
            */
            #endregion
        }
    }
}
