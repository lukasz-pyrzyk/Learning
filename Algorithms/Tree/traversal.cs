using System;

namespace Solution
{
    public class Node
    {
        public int Key { get; private set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int key)
        {
            Key = key;
        }
    }

    public class Tree
    {
        public Node Root { get; set; }

        public void PrintInorder()
        {
            PrintInorder(Root);
        }

        private void PrintInorder(Node node)
        {
            if(node == null) return;

            PrintInorder(node.Left);
            Console.Write(node.Key);
            PrintInorder(node.Right);
        }

        public void PrintPreorder()
        {
            PrintPreorder(Root);
        }

        private void PrintPreorder(Node node)
        {
            if(node == null) return;

            Console.Write(node.Key);
            PrintPreorder(node.Left);
            PrintPreorder(node.Right);
        }

        public void PrintPostorder()
        {
            PrintPostorder(Root);
        }

        private void PrintPostorder(Node node)
        {
            if(node == null) return;

            PrintPostorder(node.Left);
            PrintPostorder(node.Right);
            Console.Write(node.Key);
        }

        public static void Main()
        {
            var tree = new Tree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            Console.WriteLine();
            tree.PrintInorder();
            Console.WriteLine();
            Console.WriteLine();
            tree.PrintPreorder();
            Console.WriteLine();
            Console.WriteLine();
            tree.PrintPostorder();
            Console.WriteLine();
        }
    }
}