using System;
using System.Collections.Generic;
using System.Text;

namespace Chap_06_Linked_List
{
    public class SinglyLinkedList
    {
        private Node head;

        public void PrintLinkedList()
        {
            Node current = head;

            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void Prepend(object data)
        {
            Node node = new Node();
            node.data = data;
            node.next = head;
            head = node;
        }

        public void Append(object data)
        {
            if (head == null)
            {
                head = new Node();
                head.data = data;
                head.next = null;
            }
            else
            {
                Node node = new Node();
                node.data = data;
                Node current = head;

                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = node;
            }
        }
    }
}
