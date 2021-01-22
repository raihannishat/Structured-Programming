using System;
using System.Collections.Generic;
using System.Text;

namespace Chap_04_Sorting_Algorithm
{
    public class BubbleSort
    {
        public void Sort(int[] ara)
        {
            int temp;
            bool flag;

            for (int i = 0; i < ara.Length; i++)
            {
                flag = false;

                for (int j = 0; j < ara.Length - i - 1; j++)
                {
                    if (ara[j] > ara[j + 1])
                    {
                        temp = ara[j];
                        ara[j] = ara[j + 1];
                        ara[j + 1] = temp;
                        flag = true;
                    }
                }

                if (flag.Equals(false))
                {
                    break;
                }

                Array.ForEach(ara, x => Console.Write($"{x} "));
                Console.WriteLine();
            }
        }
    }
}
