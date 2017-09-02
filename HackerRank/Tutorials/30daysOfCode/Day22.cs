using System;

namespace _30daysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-binary-search-trees
    /// </summary>
    class Day22
    {
        public class Node
        {
            public Node left, right;
            public int data;
            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }

        private static Node Insert(Node root, int data)
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
                    cur = Insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = Insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        private static int getHeight(Node root)
        {
            if (root == null) return -1; // + 1 wil give 0

            int left = getHeight(root.left);
            int right = getHeight(root.right);

            return Math.Max(left, right) + 1;
        }

        public static void Main()
        {
            Node root = null;
            int T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = int.Parse(Console.ReadLine());
                root = Insert(root, data);
            }

            int height = getHeight(root);
            Console.WriteLine(height);
        }
    }
}
