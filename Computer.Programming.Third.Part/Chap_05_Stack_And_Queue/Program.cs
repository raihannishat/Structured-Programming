using System;

namespace Chap_05_Stack_And_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack my_stack = new Stack();

            my_stack.Push(1);
            my_stack.Push(2);
            my_stack.Push(3);

            Console.WriteLine(my_stack.Pop());
            Console.WriteLine(my_stack.Pop());
            Console.WriteLine(my_stack.Pop());
            Console.WriteLine(my_stack.Pop());

            Balanced balanced = new Balanced();

            string input = Console.ReadLine();

            if (Convert.ToBoolean(balanced.is_balanced(input.ToCharArray())))
            {
                Console.WriteLine($"{input} is balanced");
            }
            else
            {
                Console.WriteLine($"{input} is not balanced");
            }

            Bracket bracket = new Bracket();

            var str = "[({})]";

            if (bracket.IsBalanced(str))
            {
                Console.WriteLine($"{str} is balanced");
            }
            else
            {
                Console.WriteLine($"{str} is not balanced");
            }
        }
    }
}
