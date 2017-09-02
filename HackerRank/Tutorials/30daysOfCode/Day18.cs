using System;
using System.Collections.Generic;

namespace _30daysOfCode
{
    class Day18
    {
        class Solution
        {
            private readonly LinkedList<char> _queue = new LinkedList<char>();
            private readonly LinkedList<char> _stack = new LinkedList<char>();

            public void pushCharacter(char c)
            {
                _stack.AddFirst(c);
            }

            public void enqueueCharacter(char c)
            {
                _queue.AddFirst(c);
            }

            public char popCharacter()
            {
                char c = _stack.Last.Value;
                _stack.RemoveLast();
                return c;
            }

            public char dequeueCharacter()
            {
                char c = _queue.First.Value;
                _queue.RemoveFirst();
                return c;
            }
        }

        static void Main()
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Solution obj = new Solution();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}
