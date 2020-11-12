using System;

namespace Chap_09
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

            #region Code: 9.7
            /*
            char[] str1 = "Bangla".ToCharArray();
            char[] str2 = "desh".ToCharArray();
            char[] str3 = new char[12];

            int i, j, length1 = 6, length2 = 4;

            for (i = 0, j = 0; i < length1; i++, j++)
            {
                str3[j] = str1[i];
            }

            for (i = 0, j = 6; i < length2; i++, j++)
            {
                str3[j] = str2[i];
            }

            str3[j] = '\0';

            Console.WriteLine(str3);
            */
            #endregion

            #region Code: 9.7 Ex
            /*
            char[] a = new char[100];
            char[] b = new char[100];
            int result;

            a = Console.ReadLine().ToCharArray();
            b = Console.ReadLine().ToCharArray();

            result = string_compare(a, b);
            Console.WriteLine("{0}", result);
            */
            #endregion

            #region Code: 9.8
            /*
            char[] s = new char[1002];
            char[] word = new char[100];
            int i, j, length, is_word_started;

            s = Console.ReadLine().ToCharArray();

            length = s.Length;
            
            is_word_started = 0;

            for (i = 0, j = 0; i < length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    if (is_word_started == 0)
                    {
                        is_word_started = 1;
                        word[j] = (char)('A' + (s[i] - 'a'));
                        j++;
                    }
                    else
                    {
                        word[j] = s[i];
                        j++;
                    }
                }
                else if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    if (is_word_started == 0)
                    {
                        is_word_started = 1;
                    }
                    word[j] = s[i];
                    j++;
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    if (is_word_started == 0)
                    {
                        is_word_started = 1;
                    }
                    word[j] = s[i];
                    j++;
                }
                else
                {
                    if (is_word_started == 1)
                    {
                        is_word_started = 0;
                        word[j] = '\0';
                        Console.WriteLine(word);
                        j = 0;
                        word = new char[100];
                    }
                }

            }

            */
            #endregion

            #region Code: 9.8 Ex
            /*
            char[] s = new char[1002];
            char[] word = new char[100];
            int i, j, length, is_word_started;

            s = Console.ReadLine().ToCharArray();

            length = s.Length;

            is_word_started = 0;

            for (i = 0, j = 0; i < length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    if (is_word_started == 0)
                    {
                        is_word_started = 1;
                        word[j] = (char)('A' + (s[i] - 'a'));
                        j++;
                    }
                    else
                    {
                        word[j] = s[i];
                        j++;
                    }
                }
                else if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    if (is_word_started == 0)
                    {
                        is_word_started = 1;
                    }
                    word[j] = s[i];
                    j++;
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    if (is_word_started == 0)
                    {
                        is_word_started = 1;
                    }
                    word[j] = s[i];
                    j++;
                }
                else
                {
                    if (is_word_started == 1)
                    {
                        is_word_started = 0;
                        word[j] = '\0';
                        Console.WriteLine(word);
                        j = 0;
                        word = new char[100];
                    }
                }
            }

            Console.WriteLine(word);
            */
            #endregion

            #region Code: 9.9
            /*
            char[] s = new char[1002];
            char ch;
            int i, length, is_word_started;

            s = Console.ReadLine().ToCharArray();
            length = s.Length;
            is_word_started = 0;

            for (i = 0; i < length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    if (is_word_started == 0)
                    {
                        is_word_started = 1;
                        ch = (char)('A' + s[i] - 'a');
                        Console.Write("{0}", ch);
                    }
                    else
                    {
                        Console.Write("{0}", s[i]);
                    }
                }
                else if (s[i] >= 'A' && s[i] <= 'z')
                {
                    if (is_word_started == 0)
                    {
                        is_word_started = 1;
                    }

                    Console.Write("{0}", s[i]);
                }
                else
                {
                    if (is_word_started == 1)
                    {
                        is_word_started = 0;
                        Console.WriteLine();
                    }
                }
            }
            */
            #endregion
        }

        #region Function 9.7 Ex - 1
        /*
        static int str_len(char[] str)
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

        #region Function 9.7 Ex - 2
        /*
        static int string_compare(char[] a, char[] b)
        {
            int i;

            for (i = 0; a[i] != a.Length && b[i] != b.Length; i++)
            {
                if (a[i] < b[i])
                {
                    return -1;
                }

                if (a[i] > b[i])
                {
                    return 1;
                }
            }

            if (str_len(a) < str_len(b))
            {
                return -1;
            }
            else if (str_len(a) > str_len(b))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        */
        #endregion

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
