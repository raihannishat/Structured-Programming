using System;

namespace Chap_9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code: 9.1
            /*
            char[] country = { 'B', 'a', 'n', 'g', 'l', 'a', 'd', 'e', 's', 'h'};
            Console.WriteLine(country);
            */
            #endregion

            #region Code: 9.2
            /*
            char[] country =
            {
                'B', 'a', 'n', 'g', 'l', 'a', 'd', 'e', 's', 'h',
                ' ', 'i', 's', ' ', 'm', 'y', ' ', 'c', 'o', 'u', 'n', 't', 'r', 'y'
            };

            Console.WriteLine(country);
            */
            #endregion

            #region Code: 9.3
            /*
            char[] country =
            {
                'B', 'a', 'n', 'g', 'l', 'a', 'd', 'e', 's', 'h',
                '\0', 'i', 's', ' ', 'm', 'y', ' ', 'c', 'o', 'u', 'n', 't', 'r', 'y'
            };

            Console.WriteLine(country);
            */
            #endregion

            #region Code: 9.4
            /*
            char[] country = { 'B', 'a', 'n', 'g', 'l', 'a', 'd', 'e', 's', 'h' };
            int i, length;
            Console.WriteLine(country);
            length = 10;

            for (i = 0; i < length; i++)
            {
                if (country[i] >= 'a' && country[i] <= 'z')
                {
                    country[i] = (char)('A' + (country[i] - 'a'));
                }
            }
            
            Console.WriteLine(country);
            */
            #endregion

            #region Code: 9.5
            /*
            char[] country = new char[100];
            int length;

            while (true)
            {
                country = Console.ReadLine().ToCharArray();
                length = string_length(country);
                Console.WriteLine("length: {0}", length);
            }
            */
            #endregion

            #region Code: 9.6
            /*
            char[] ara = new char[100];

            while (true)
            {
                ara = Console.ReadLine().ToCharArray();
                Console.WriteLine(ara);
            }
            */
            #endregion


        }

        #region Function: 9.5
        /*
        static int string_length(char[] str)
        {
            int i, length = 0;

            for (i = 0; i < str.Length; i++)
            {
                length++;
            }
            
            return length;
        }
        */
        #endregion

        #region Function: 9.5 Ex
        /*
        static int string_length(char[] str)
        {
            int i = 0, length = 0;

            while (i < str.Length)
            {
                length++;
                i++;
            }
            
            return length;
        }
        */
        #endregion
    }
}
