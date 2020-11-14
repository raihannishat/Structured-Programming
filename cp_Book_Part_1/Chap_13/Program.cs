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

            #region Code: 13.1
            /*
            char[] word = new char[80];
            char[] reverse_word = new char[80];
            int i, j, len;

            word = Console.ReadLine().ToCharArray();
            len = word.Length;

            for (i = 0, j = len - 1; i < len; i++, j--)
            {
                reverse_word[i] = word[j];
            }

            reverse_word[i] = '\0';
            Console.WriteLine(reverse_word);

            string str1 = new string(word);
            string str2 = new string(reverse_word);

            if (0 == str1.CompareTo(str2))
            {
                Console.WriteLine("{0} is palindrome.", str1);
            }
            else
            {
                Console.WriteLine("{0} is not palindrome.", str1);
            }
            */
            #endregion

            #region Code: 13.1 Ex - 1
            /*
            char[] word = new char[80];
            int i, j, len, rev = 0;

            word = Console.ReadLine().ToCharArray();
            len = word.Length;

            for (i = 0, j = len - 1; i < len; i++, j--)
            {
                if (word[i] != word[j])
                {
                    rev = 1;
                    break;
                }
            }

            string str = new string(word);

            if (0 == rev)
            {
                Console.WriteLine("{0} is palindrome.", str);
            }
            else
            {
                Console.WriteLine("{0} is not palindrome.", str);
            }
            */
            #endregion

            #region Code: 13.1 Ex - 2
            /*
            Console.Write("Enter a number (2 - 99): ");
            int i, number, prime_position, total;

            number = Convert.ToInt32(Console.ReadLine());

            int[] primes = 
            {
                2,  3,  5,  7,  11,
                13, 17, 19, 23, 29, 
                31, 37, 41, 43, 47, 
                53, 59, 61, 67, 71, 
                73, 79, 83, 89, 97
            };

            for (i = 0; i < number; i++)
            {
                prime_position = primes[i];
                total = 0;

                while (prime_position <= number)
                {
                    total = total + (number / prime_position);
                    prime_position = prime_position * primes[i];
                }

                if (total != 0 && primes[i] <= number)
                {
                    Console.WriteLine("({0}, {1})", primes[i], total);
                }
            }
            */
            #endregion

            #region Code: 13.2
            /*
            int[] ara1 = { 3, 1, 5, 2, 4 };
            int[] ara2 = new int[5];

            int i, minimum, index_2;

            for (index_2 = 0; index_2 < 5; index_2++)
            {
                minimum = 10000;

                for (i = 0; i < 5; i++)
                {
                    if (ara1[i] < minimum)
                    {
                        minimum = ara1[i];
                    }
                }

                ara2[index_2] = minimum;
            }

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}", ara2[i]);
            }
            */
            #endregion

            #region Code: 13.3
            /*
            int[] ara1 = { 3, 1, 5, 2, 4 };
            int[] ara2 = new int[5];

            int i, minimum, index_2, minimum_index = 0;

            for (index_2 = 0; index_2 < 5; index_2++)
            {
                minimum = 10000;

                for (i = 0; i < 5; i++)
                {
                    if (ara1[i] < minimum)
                    {
                        minimum = ara1[i];
                        minimum_index = i;
                    }
                }

                ara1[minimum_index] = 10000;
                ara2[index_2] = minimum;
            }

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}", ara2[i]);
            }
            */
            #endregion

            #region Code: 13.4
            /*
            int x, y;
            char c;

            Console.Write("Please enter the initial position: ");

            var line = Console.ReadLine().Split(' ');
            x = Convert.ToInt32(line[0]);
            y = Convert.ToInt32(line[1]);

            while (true)
            {
                c = Convert.ToChar(Console.ReadLine());

                if (c.Equals('S'))
                {
                    break;
                }
                else if (c.Equals('U'))
                {
                    x--;
                }
                else if (c.Equals('D'))
                {
                    x++;
                }
                else if (c.Equals('R'))
                {
                    y++;
                }
                else if (c.Equals('L'))
                {
                    y--;
                }
            }

            Console.WriteLine("Final position of the robot is: {0}, {1}", x, y);
            */
            #endregion

            #region Code: 13.4 Ex - 1
            /*
            int[,] grid = new int[10, 10];
            
            int i, j, x, y, a, b, n;
            char c;
            string[] line = null;

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    grid[i, j] = 1;
                }
            }

            Console.Write("Enter the number of block cells: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Now enter the block cells: ");

            for (i = 0; i < n; i++)
            {
                line = Console.ReadLine().Split(' ');
                a = Convert.ToInt32(line[0]);
                b = Convert.ToInt32(line[1]);
                grid[a, b] = 0;
            }

            Console.Write("Please enter the initial position: ");
            line = Console.ReadLine().Split(' ');
            x = Convert.ToInt32(line[0]);
            y = Convert.ToInt32(line[1]);

            Console.WriteLine("Now enter the cells.");

            while (true)
            {
                c = Convert.ToChar(Console.ReadLine());

                if (c.Equals('S'))
                {
                    break;
                }
                else if (c.Equals('U'))
                {
                    x--;
                    if (grid[x, y].Equals(1))
                    {
                        Console.WriteLine("Now position of the cell: {0}, {1}", x, y);
                    }
                    else
                    {
                        Console.WriteLine("The cell is blocked.");
                    }
                }
                else if (c.Equals('D'))
                {
                    x++;
                    if (grid[x, y].Equals(1))
                    {
                        Console.WriteLine("Now position of the cell: {0}, {1}", x, y);
                    }
                    else
                    {
                        Console.WriteLine("The cell is blocked.");
                    }
                }
                else if (c.Equals('R'))
                {
                    y++;
                    if (grid[x, y].Equals(1))
                    {
                        Console.WriteLine("Now position of the cell: {0}, {1}", x, y);
                    }
                    else
                    {
                        Console.WriteLine("The cell is blocked.");
                    }
                }
                else if (c.Equals('L'))
                {
                    y--;
                    if (grid[x, y].Equals(1))
                    {
                        Console.WriteLine("Now position of the cell: {0}, {1}", x, y);
                    }
                    else
                    {
                        Console.WriteLine("The cell is blocked.");
                    }
                }
            }
            */
            #endregion
        }
    }
}
