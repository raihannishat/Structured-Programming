using System;

namespace Chap_11_Array_Again
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

            #region Code: 11.2
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

            #region Code: 11.2 Ex
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

            #region Code: 11.3
            /*
            string[] saarc = new string[]
            {
                "Bangladesh",
                "India",
                "Pakistan",
                "Sri Lanka",
                "Nepal",
                "Bhutan",
                "Maldives"
            };

            int row;

            for (row = 0; row < 7; row++)
            {
                Console.WriteLine("{0}", saarc[row]);
            }
            */

            #endregion

            #region Code: 11.4
            /*
            string[] saarc = new string[]
            {
                "Bangladesh",
                "India",
                "Pakistan",
                "Sri Lanka",
                "Nepal",
                "Bhutan",
                "Maldives"
            };

            int row, col, name_length;

            for (row = 0; row < 7; row++)
            {
                name_length = saarc[row].Length;

                for (col = 0; col < name_length; col++)
                {
                    Console.Write("{0}", saarc[row].ToCharArray()[col]);
                }

                Console.WriteLine();
            }
            */
            #endregion

            #region Code: 11.5
            /*
            string[] saarc = new string[]
            {
                "Bangladesh",
                "India",
                "Pakistan",
                "Sri Lanka",
                "Nepal",
                "Bhutan",
                "Maldives"
            };

            int row, col, name_length;

            for (row = 0; row < 7; row++)
            {
                name_length = saarc[row].Length;

                for (col = 0; col < name_length; col++)
                {
                    Console.Write("[{0},{1}] = {2}, ", row, col, saarc[row].ToCharArray()[col]);
                }

                Console.WriteLine();
            }
            */
            #endregion

            #region Code: 11.5 Ex - 1
            /*
            int[,] ara = new int[5, 5]
            {
                { 6, 4, 7, 8, 9 },
                { 3, 7, 1, 9, 9 },
                { 8, 6, 4, 2, 7 },
                { 2, 4, 2, 5, 9 },
                { 4, 1, 6, 7, 3 }
            };

            int row, col, sum = 0;

            for (row = 0; row < 5; row++)
            {
                for (col = 0; col < 5; col++)
                {
                    sum += ara[row, col];
                }

                Console.WriteLine("Sum of row: {0} is: {1}", row + 1, sum);
                sum = 0;
            }
            */
            #endregion

            #region Code: 11.5 Ex - 2
            /*
            int[,] ara = new int[5, 5]
            {
                { 6, 4, 7, 8, 9 },
                { 3, 7, 1, 9, 9 },
                { 8, 6, 4, 2, 7 },
                { 2, 4, 2, 5, 9 },
                { 4, 1, 6, 7, 3 }
            };

            int row, col, sum = 0;

            for (col = 0; col < 5; col++)
            {
                for (row = 0; row < 5; row++)
                {
                    sum += ara[row, col];
                }

                Console.WriteLine("Sum of col: {0} is: {1}", col + 1, sum);
                sum = 0;
            }
            */
            #endregion

            #region Code: 11.6
            /*
            int[,] ara1 = new int[5, 5]
            {
                { 1, 2, 3, 4, 5 },
                { 10, 20, 30, 40, 50 },
                { 100, 200, 300, 400, 500 },
                { 1000, 2000, 3000, 4000, 5000 },
                { 10000, 20000, 30000, 40000, 50000 }
            };

            int[,] ara2 = new int[5, 5];
            int r, c;

            Console.WriteLine("Content of first array (ara1): ");

            for (r = 0; r < 5; r++)
            {
                for (c = 0; c < 5; c++)
                {
                    Console.Write("{0} ", ara1[r, c]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // now start copy
            for (r = 0; r < 5; r++)
            {
                for (c = 0; c < 5; c++)
                {
                    ara2[c, r] = ara1[r, c];
                }
            }

            Console.WriteLine("Content of second array (ara2): ");

            for (r = 0; r < 5; r++)
            {
                for (c = 0; c < 5; c++)
                {
                    Console.Write("{0} ", ara2[r, c]);
                }

                Console.WriteLine();
            }
            */
            #endregion
        }
    }
}
