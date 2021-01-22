using System;
using System.Collections.Generic;
using System.Text;

namespace Chap_04_Sorting_Algorithm
{
    public class InsertionSort
    {
        public void Sort(int[] ara)
        {
            int item, i, j;

            for (i = 1; i < ara.Length; i++)
            {
                item = ara[i];

                j = i - 1;

                while (j >= 0 && ara[j] > item)
                {
                    ara[j + 1] = ara[j];
                    j = j - 1;
                }

                ara[j + 1] = item;
            }
        }
    }
}
