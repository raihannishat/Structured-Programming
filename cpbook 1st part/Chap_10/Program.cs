using System;

namespace Chap_10
{
    class Program
    {
        // const int size = 40;
        // static int[] ara = new int[40];

        static void Main(string[] args)
        {
            #region Code: 10.1
            /*
            int n;

            while (true)
            {
                Console.Write("Please enter a number (enter 0 to exit): ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n == 0)
                {
                    break;
                }

                if (1 == is_prime(n))
                {
                    Console.WriteLine("{0} is a prime number.", n);
                }
                else
                {
                    Console.WriteLine("{0} is not a prime number.", n);
                }
            }
            */
            #endregion

            #region Code: 10.2
            /*
            int n, m;

            while (true)
            {
                Console.Write("Please enter a number (enter 0 to exit): ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n == 0)
                {
                    break;
                }

                if (1 == is_prime(n))
                {
                    Console.WriteLine("{0} is a prime number.", n);
                }
                else
                {
                    Console.WriteLine("{0} is not a prime number.", n);
                }
            }
            */
            #endregion

            #region Code: 10.3
            /*
            int n;

            sieve();

            while (true)
            {
                Console.Write("Please enter a number (enter 0 to exit): ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n == 0)
                {
                    break;
                }

                if (n >= size)
                {
                    Console.WriteLine("The number should be less than {0}", size);
                    continue;
                }

                if (1 == is_prime(n))
                {
                    Console.WriteLine("{0} is a prime number.", n);
                }
                else
                {
                    Console.WriteLine("{0} is not a prime number.", n);
                }
            }
            */
            #endregion
        }

        #region Function: 10.1
        /*
        static int is_prime(int n)
        {
            int i;

            if (n < 2)
            {
                return 0;
            }

            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return 0;
                }
            }

            return 1;
        }
        */
        #endregion

        #region Function: 10.1 Ex
        /*
        static int is_prime(int n)
        {
            int i;

            if (n < 2)
            {
                return 0;
            }

            if (n == 2)
            {
                return 1;
            }

            if (n % 2 == 0)
            {
                return 0;
            }

            for (i = 3; i <= n / 2; i = i + 2)
            {
                if (n % i == 0)
                {
                    return 0;
                }
            }

            return 1;
        }
        */
        #endregion

        #region Function: 10.2
        /*
        static int is_prime(int n)
        {
            int i, root;

            if (n < 2)
            {
                return 0;
            }

            if (n == 2)
            {
                return 1;
            }

            if (n % 2 == 0)
            {
                return 0;
            }

            root = (int) Math.Sqrt(n);

            for (i = 3; i <= root; i = i + 2)
            {
                if (n % i == 0)
                {
                    return 0;
                }
            }

            return 1;
        }
        */
        #endregion

        #region Function: 10.3
        /*
        static void print_ara()
        {
            int i;

            for (i = 2; i < size; i++)
            {
                Console.Write("\t{0} ", ara[i]);
            }
            
            Console.WriteLine();

            for (i = 2; i < size; i++)
            {
                Console.Write("-----");
            }

            Console.WriteLine();

            for (i = 2; i < size; i++)
            {
                Console.Write("\t{0} ", i);
            }

            Console.WriteLine("\n\n\n");
        }

        static void sieve()
        {
            int i, j, root;

            for (i = 2; i < size; i++)
            {
                ara[i] = 1;
            }

            root = (int) Math.Sqrt(size);
            print_ara();

            for (i = 2; i <= root; i++)
            {
                if (ara[i] == 1)
                {
                    for (j = 2; i * j < size; j++)
                    {
                        ara[i * j] = 0;
                    }
                    print_ara();
                }
            }
        }

        static int is_prime(int n)
        {
            if (n < 2)
            {
                return 0;
            }

            return ara[n];
        }
        */
        #endregion
    }
}
