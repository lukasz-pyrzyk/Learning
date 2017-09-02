using System;
using System.Collections.Generic;

namespace _30daysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-binary-trees
    /// </summary>
    class Day23
    {
        class Node
        {
            public Node left, right;
            public int data;
            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }

        private static void levelOrder(Node root)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                Console.Write(item.data + " ");
                if(item.left != null) queue.Enqueue(item.left);
                if(item.right != null) queue.Enqueue(item.right);
            }
        }

        private static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }

                return root;
            }
        }

        public static void Main()
        {
            Node root = null;
            int T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = int.Parse(Console.ReadLine());
                root = insert(root, data);
            }

            levelOrder(root);
        }
    }
}
