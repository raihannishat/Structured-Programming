using System;

namespace Chap_06_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code: 6.1
            /*
            int ft_marks, st_marks, final_marks;
            double total_marks;

            ft_marks = 80;
            st_marks = 74;
            final_marks = 97;

            total_marks = ft_marks / 4.0 + st_marks / 4.0 + final_marks / 2.0;

            Console.WriteLine("{0:0.00}", total_marks);
            */
            #endregion

            #region Code: 6.2
            /*
            int[] ara = new int[5] {10, 20, 30, 40, 50};

            Console.WriteLine("First element: {0}", ara[0]);
            Console.WriteLine("Thirs element: {0}", ara[2]);
            */
            #endregion

            #region Code: 6.3
            /*
            int[] ara = new int[5] {6, 7, 4, 6, 9};

            Console.WriteLine("{0}", ara[-1]);
            Console.WriteLine("{0}", ara[5]);
            Console.WriteLine("{0}", ara[100]);
            */
            #endregion

            #region Code: 6.4
            /*
            int[] ara = new int[10] {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
            int i;

            for (i = 0; i < ara.Length; i++)
            {
                Console.WriteLine("{0} th element is: {1}", i + 1, ara[i]);
            }
            */
            #endregion

            #region Code: 6.5
            /*
            int[] ara = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
            int[] ara2 = new int[10];
            int i, j;

            for (i = 0, j = 9; i < ara.Length; i++, j--)
            {
                ara2[j] = ara[i];
            }

            for (i = 0; i < ara.Length; i++)
            {
                ara[i] = ara2[i];
            }

            for (i = 0; i < ara.Length; i++)
            {
                Console.WriteLine("{0}", ara[i]);
            }
            */
            #endregion

            #region Code: 6.6
            /*
            int[] ara = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
            int i, j, temp;

            for (i = 0, j = 9; i < ara.Length; i++, j--)
            {
                temp = ara[j];
                ara[j] = ara[i];
                ara[i] = temp;
            }

            for (i = 0; i < ara.Length; i++)
            {
                Console.WriteLine("{0}", ara[i]);
            }
            */
            #endregion

            #region Code: 6.6 Ex
            /*
            int[] ara = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
            int i, j, temp;

            for (i = 0, j = 9; i < 5; i++, j--)
            {
                temp = ara[j];
                ara[j] = ara[i];
                ara[i] = temp;
            }

            for (i = 0; i < ara.Length; i++)
            {
                Console.WriteLine("{0}", ara[i]);
            }
            */
            #endregion

            #region Code: 6.7
            /*
            int[] ft_marks = new int[40] { 83, 86, 97, 95, 93, 95, 86, 52, 49, 41, 42, 47, 90, 59, 63, 86, 40, 46, 92, 56, 51, 48, 67, 49, 42, 90, 42, 83, 47, 95, 69, 82, 82, 58, 69, 67, 53, 56, 71, 62 };
            int[] st_marks = new int[40] { 86, 97, 95, 93, 95, 86, 52, 49, 41, 42, 47, 90, 59, 63, 86, 40, 46, 92, 56, 51, 48, 67, 49, 42, 90, 42, 83, 47, 95, 69, 82, 82, 58, 69, 67, 53, 56, 71, 62, 49 };
            int[] final_marks = new int[40] { 87, 64, 91, 43, 89, 66, 58, 73, 99, 81, 100, 64, 55, 69, 85, 81, 80, 67, 88, 71, 62, 78, 58, 66, 98, 75, 86, 90, 80, 58, 100, 64, 55, 69, 85, 81, 80, 67, 88, 71 };

            int i;
            double[] total_marks = new double[40];

            for (i = 0; i < total_marks.Length; i++)
            {
                total_marks[i] = ft_marks[i] / 4.0 + st_marks[i] / 4.0 + final_marks[i] / 2.0;
            }

            for (i = 1; i <= total_marks.Length; i++)
            {
                Console.WriteLine("Roll NO: {0}\tTotal marks: {1:0.00}", i, total_marks[i - 1]);
            }
            */
            #endregion

            #region Code: 6.8
            /*
            int marks, i, count;
            int[] total_marks = { 86, 78, 94, 68, 92, 78, 64, 62, 72, 61, 72, 66, 65, 65, 80, 72, 62, 68, 81, 62, 56, 68, 58, 56, 82, 70, 74, 78, 76, 84, 88, 73, 62, 66, 76, 70, 67, 65, 77, 63 };

            for (marks = 50; marks <= 100; marks++)
            {
                count = 0;

                for (i = 0; i < 40; i++)
                {
                    if (total_marks[i] == marks)
                    {
                        count++;
                    }
                }

                Console.WriteLine("Marks: {0} Count: {1}", marks, count);
            }
            */
            #endregion

            #region Code: 6.9
            /*
            int i;
            int[] total_marks = { 86, 78, 94, 68, 92, 78, 64, 62, 72, 61, 72, 66, 65, 65, 80, 72, 62, 68, 81, 62, 56, 68, 58, 56, 82, 70, 74, 78, 76, 84, 88, 73, 62, 66, 76, 70, 67, 65, 77, 63 };

            int[] marks_count = new int[101];

            for (i = 0; i < 101; i++)
            {
                marks_count[i] = 0;
            }

            for (i = 0; i < 40; i++)
            {
                marks_count[total_marks[i]]++;
            }

            for (i = 50; i <= 100; i++)
            {
                Console.WriteLine("Marks: {0} Count: {1}", i, marks_count[i]);
            }
            */
            #endregion

            #region Code: 6.10
            /*
            int i, j;
            int[] total_marks = { 6, 7, 4, 6, 9, 7, 6, 2, 4, 3, 4, 1 };
            int[] marks_count = new int[11];

            for (i = 0; i < 11; i++)
            {
                marks_count[i] = 0;
            }

            for (i = 0; i < 12; i++)
            {
                marks_count[total_marks[i]]++;

                for (j = 0; j <= 10; j++)
                {
                    Console.Write("{0} ", marks_count[j]);
                }

                Console.WriteLine();
            }
            */
            #endregion
        }
    }
}
