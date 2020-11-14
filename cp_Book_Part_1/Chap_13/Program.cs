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
        }
    }
}
