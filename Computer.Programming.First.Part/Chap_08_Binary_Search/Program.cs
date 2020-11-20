using System;

namespace Chap_08_Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code: 8.1
            /*
            int[] ara = { 1, 4, 6, 8, 9, 11, 14, 15, 20, 25, 33, 83, 87, 97, 99, 100 };

            int low_indx = 0;
            int high_indx = 15;
            int mid_indx = 0;
            int num = 97;

            binary_search(ara, low_indx, high_indx, num);
            
            while (low_indx <= high_indx)
            {
                mid_indx = (low_indx + high_indx) / 2;
                if (num == ara[mid_indx])
                {
                    break;
                }
                if (num < ara[mid_indx])
                {
                    high_indx = mid_indx - 1;
                }
                else
                {
                    low_indx = mid_indx + 1;
                }
            }

            if (low_indx > high_indx)
            {
                Console.WriteLine("{0} is not in the array", num);
            }
            else
            {
                Console.WriteLine("{0} is found in the array. It is the {1} th element of the array.", ara[mid_indx], mid_indx);
            }
            */
            #endregion
        }

        #region Function: 8.1 Ex
        /*
        static void binary_search(int[] ara, int low, int high, int num)
        {
            int mid = 0;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (num == ara[mid])
                {
                    break;
                }

                if (num < ara[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            if (low > high)
            {
                Console.WriteLine("{0} is not in the array", num);
            }
            else
            {
                Console.WriteLine("{0} is found in the array. It is the {1} th element of the array.", ara[mid], mid);
            }
        }
        */
        #endregion
    }
}
