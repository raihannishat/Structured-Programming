using System;

namespace Chap_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code: 3.1
            /*
            int n;

            n = 10;

            if (n >= 0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is negative");
            }
            */
            #endregion

            #region Code: 3.2
            /*
            int n;
            n = 10;
            
            if (n > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is negative");
            }
            */
            #endregion

            #region Code: 3.3
            /*
            int n = 10;

            if (n < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else if (n > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (n == 0)
            {
                Console.WriteLine("The number is zero!");
            }
            */
            #endregion

            #region Code: 3.4
            /*
            int n = 10;

            if (n < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else if (n > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is zero!");
            }
            */
            #endregion

            #region Code: 3.5
            /*
            int number = 12;

            if (number > 10)
            {
                Console.WriteLine("The number is greater than ten.");
            }
            */
            #endregion

            #region Code: 3.6
            /*
            int n = 10;

            if (n < 30)
            {
                Console.WriteLine("{0} is less than 30.", n);
            }
            else if (n < 50)
            {
                Console.WriteLine("{0} is less than 50.", n);
            }
            */
            #endregion

            #region Code: 3.7
            /*
            int n = 10;

            if (n < 30)
            {
                Console.WriteLine("{0} is less than 30.", n);
            }
            if (n < 50)
            {
                Console.WriteLine("{0} is less than 50.", n);
            }
            */
            #endregion

            #region Code: 3.8
            /*
            int number, remainder;
            number = 5;

            remainder = number % 2;

            if (remainder == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            */
            #endregion

            #region Code: 3.9
            /*
            int number = 9;

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            */
            #endregion

            #region Code: 3.9 Ex
            /*
            int n, value;

            n = Convert.ToInt32(Console.ReadLine());

            value = n - 2 * (n / 2);

            if (value == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            */
            #endregion

            #region Code: 3.10
            /*
            char ch = 'w';

            if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("{0} is lower case", ch);
            }
            if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("{0} is upper case", ch);
            }
            */
            #endregion

            #region Code: 3.11
            /*
            char ch = 'k';

            if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("{0} is lower case", ch);
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("{0} is upper case", ch);
            }
            */
            #endregion

            #region Code: 3.12
            /*
            int num = 5;
            if (num >= 1 || num <= 10)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            */
            #endregion

            #region Code: 3.12 Ex
            /*
            char ch = 'a';

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("{0} is vowel.", ch);
            }
            else
            {
                Console.WriteLine("{0} is consonant.", ch);
            }
            */
            #endregion
        }
    }
}
