using System;
using System.Collections.Generic;
using System.Text;

namespace Chap_04_Sorting_Algorithm
{
    public class SelectionSort
    {
        public void Sort(int[] ara)
        {
            int index_min, temp;

            for (int i = 0; i < ara.Length - 1; i++)
            {
                index_min = i;

                for (int j = i + 1; j < ara.Length; j++)
                {
                    if (ara[j] < ara[index_min])
                    {
                        index_min = j;
                    }
                }

                if (index_min != i)
                {
                    temp = ara[i];
                    ara[i] = ara[index_min];
                    ara[index_min] = temp;
                }
            }
        }
    }
}
