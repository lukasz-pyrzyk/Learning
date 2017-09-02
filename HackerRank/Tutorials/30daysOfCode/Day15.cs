using System;

namespace _30daysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-linked-list
    /// </summary>
    public class Day15
    {
        class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }

            public static Node insert(Node head, int data)
            {
                var node = new Node(data);
                if (head == null) return node;

                var current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;


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

            static void Main(String[] args)
            {
                Node head = null;
                int T = Int32.Parse(Console.ReadLine());
                while (T-- > 0)
                {
                    int data = Int32.Parse(Console.ReadLine());
                    head = insert(head, data);
                }
                display(head);
            }
        }
    }
}