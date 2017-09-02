using System;
using System.Collections.Generic;

namespace _30daysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-linked-list-deletion
    /// </summary>
    class Day24
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        private static Node removeDuplicates(Node head)
        {
            var current = head;
            while (current.next != null)
            {
                if (current.data == current.next.data)
                    current.next = current.next.next;
                else
                    current = current.next;
            }

            return head;
        }

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        public static void Main()
        {

            Node head = null;
            int T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = int.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }
    }
}
