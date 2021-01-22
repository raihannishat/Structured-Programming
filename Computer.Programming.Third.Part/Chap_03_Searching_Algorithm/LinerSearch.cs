using System;
using System.Collections.Generic;
using System.Text;

namespace Chap_03_Searching_Algorithm
{
    public class LinerSearch
    {
        public int Search(int[] ara, int x)
        {
            for (int i = 0; i < ara.Length; i++)
            {
                if (ara[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
