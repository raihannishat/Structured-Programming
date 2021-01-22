using System;

namespace Chap_03_Searching_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            LinerSearch linerSearch = new LinerSearch();
            BinarySearch binarySearch = new BinarySearch();

            int[] ara = { 10, 20, 80, 30, 60, 50, 110, 100, 130, 170 };
            int[] ara2 = { 1, 5, 10, 25, 40, 100 };
            
            Console.WriteLine(linerSearch.Search(ara, 50));
            Console.WriteLine(binarySearch.Search(ara2, 25));
        }
    }
}
