using System;

namespace Chap_04_Sorting_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ara = { 86, 78, 94, 68, 92, 78, 64, 62, 72, 61, 72, 66, 65, 65 };

            Display(ara, new SelectionSort());
            Display(ara, new BubbleSort());
            Display(ara, new InsertionSort());
        }

        static void Display(int[] ara, object sort)
        {
            Console.Write($"{sort.GetType().Name} :\t");

            foreach (var item in ara)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
