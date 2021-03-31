using System;

namespace Chap_06_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList linkedList = new SinglyLinkedList();
            linkedList.Prepend(1);
            linkedList.Prepend(2);
            linkedList.Prepend(3);
            linkedList.PrintLinkedList();
        }
    }
}
