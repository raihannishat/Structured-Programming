using System;
using System.Net.Http.Headers;

namespace Chap_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code: 5.1
            /*
            double x, y, x_plus_y, x_minus_y;

            Console.Write("Enter the value of x + y: ");
            x_plus_y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of x - y: ");
            x_minus_y = Convert.ToDouble(Console.ReadLine());

            x = (x_plus_y + x_minus_y) / 2;
            y = (x_plus_y - x_minus_y) / 2;

            Console.WriteLine("x = {0:0.##}, y = {1:0.##}", x, y);
            */
            #endregion

            #region Code: 5.2
            /*
            double a1, a2, b1, b2, c1, c2, x, y;

            Console.Write("a1 = ");
            a1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("a2 = ");
            a2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("b1 = ");
            b1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("b2 = ");
            b2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("c1 = ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("c2 = ");
            c2 = Convert.ToInt32(Console.ReadLine());

            x = (b2 * c1 - b1 * c2) / (a1 * b2 - a2 * b1);
            y = (a1 * c2 - a2 * c1) / (a1 * b2 - a2 * b1);

            Console.WriteLine("x = {0:0.##}, y = {1:0.##}", x, y);
            */
            #endregion

            #region Code: 5.3
            /*
            double a1, a2, b1, b2, c1, c2, d, x, y;

            Console.Write("a1 = ");
            a1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("a2 = ");
            a2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("b1 = ");
            b1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("b2 = ");
            b2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("c1 = ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("c2 = ");
            c2 = Convert.ToInt32(Console.ReadLine());

            d = a1 * b2 - a2 * b1;

            if ((int)d == 0)
            {
                Console.WriteLine("The value of x and y can not be determined.");
            }
            else
            {
                x = (b2 * c1 - b1 * c2);
                y = (a1 * c2 - a2 * c1);
                Console.WriteLine("x = {0:0.##}, y = {1:0.##}", x, y);
            }
            */
            #endregion

            #region Code: 5.4
            /*
            double loan_amount, interest_rate, number_of_years, total_amount, monthly_amount;

            Console.Write("Enter the loan amount: ");
            loan_amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the interest rate: ");
            interest_rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Numbers of years: ");
            number_of_years = Convert.ToDouble(Console.ReadLine());

            total_amount = loan_amount + loan_amount * interest_rate / 100.00;
            monthly_amount = total_amount / (number_of_years * 12);

            Console.WriteLine("Total amount: {0:0.##}", total_amount);
            Console.WriteLine("Monthly amount: {0:0.##}", monthly_amount);
            */
            #endregion

            #region Code: 5.4 Ex
            /*
            double loan_amount, interest_rate, number_of_years, total_amount, monthly_amount;

            Console.Write("Enter the loan amount: ");
            loan_amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the interest rate: ");
            interest_rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Numbers of years: ");
            number_of_years = Convert.ToDouble(Console.ReadLine());

            total_amount = loan_amount + loan_amount * interest_rate * number_of_years / 100.00;
            monthly_amount = total_amount / (number_of_years * 12);

            Console.WriteLine("Total amount: {0:.##}", total_amount);
            Console.WriteLine("Monthly amount: {0:.##}", monthly_amount);
            */
            #endregion

            #region Code: v = u + at
            /*
            var line = Console.ReadLine().Split(' ');

            int t = Convert.ToInt32(line[0]);
            int v = Convert.ToInt32(line[1]);

            Console.WriteLine("Ans: {0}", 2 * t * v);
            */
            #endregion

            #region Code: 5.5
            /*
            int n, sum;

            n = Convert.ToInt32(Console.ReadLine());
            sum = n * (n + 1) / 2;

            Console.WriteLine("Summation is {0}", sum);
            */
            #endregion

            #region Code: 5.6
            /*
            int i, n, sum;

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1, sum = 0; i <= n; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("Summation is {0}", sum);
            */
            #endregion

            #region Code: 5.6 Ex
            /*
            int i, n, sum = 0;

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i = i + 2)
            {
                sum = sum + i;
            }

            Console.WriteLine("Summation is {0}", sum);
            */
            #endregion

            #region Code: 5.7
            /*
            double celsius, farenheit;

            Console.Write("Enter the temperature in celsius: ");
            celsius = Convert.ToInt32(Console.ReadLine());

            farenheit = (celsius * 1.8) + 32;

            Console.WriteLine("The temperature in farenheit is: {0:0.##}", farenheit);
            */
            #endregion

            #region Code: 5.7 Ex
            /*
            double celsius, farenheit;

            Console.Write("Enter the temperature in farenheit: ");
            farenheit = Convert.ToInt32(Console.ReadLine());

            celsius = (farenheit - 32) / 1.8;

            Console.WriteLine("The temperature in farenheit is: {0:0.##}", celsius);
            */
            #endregion

            #region Code: 5.8
            /*
            int a, b, x, gcd = 0;

            var line = Console.ReadLine().Split(' ');

            a = Convert.ToInt32(line[0]);
            b = Convert.ToInt32(line[1]);

            if (a < b)
            {
                x = a;
            }
            else
            {
                x = b;
            }

            for (; x >= 1; x--)
            {
                if (a % x == 0 && b % x == 0)
                {
                    gcd = x;
                    break;
                }
            }
            
            Console.WriteLine("GCD is {0}", gcd);
            */
            #endregion

            #region Code: 5.9
            /*
            int a, b, t, gcd;

            var line = Console.ReadLine().Split(' ');

            a = Convert.ToInt32(line[0]);
            b = Convert.ToInt32(line[1]);

            if (a == 0) 
            {
                gcd = a;
            } 
            else if (b == 0)
            {
                gcd = b;
            }
            else
            {
                while (b != 0)
                {
                    t = b;        
                    b = a % b;  
                    a = t;
                }

                gcd = a;
            }
            
            Console.WriteLine("GCD is {0}", gcd);
            */
            #endregion

            #region Code: 5.9 Ex
            /*
            int a, b, x, y, reminder, gcd, lcm;

            var line = Console.ReadLine().Split(' ');

            a = Convert.ToInt32(line[0]);
            b = Convert.ToInt32(line[1]);

            x = a;
            y = b;

            while (b != 0)
            {
                reminder = a % b;
                a = b;
                b = reminder;
            }

            gcd = a;
            lcm = (x * y) / gcd;

            Console.WriteLine("GCD = {0}, LCM = {1}", gcd, lcm);
            */
            #endregion
        }
    }
}
