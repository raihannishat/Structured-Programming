using System;
using System.Collections.Generic;
using System.Text;

namespace Chap_03_Searching_Algorithm
{
    public class BinarySearch
    {
        public int Search(int[] ara, int x)
        {
            int left, right, mid;
            left = 0;
            right = ara.Length - 1;

            while (left <= right)
            {
                mid = (left + right) / 2;

                if (ara[mid] == x)
                {
                    return mid;
                }

                if (ara[mid] < x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}
