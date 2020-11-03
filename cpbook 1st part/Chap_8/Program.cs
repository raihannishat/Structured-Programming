using System;

namespace Chap_8
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
    }
}
