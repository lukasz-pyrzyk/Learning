using System;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/kangaroo
    /// </summary>
    class _04_Kangaroo
    {
        public static void Main()
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);

            bool result = Calculate(x1, v1, x2, v2);

            Console.Write(result ? "YES" : "NO");
        }

        private static bool Calculate(int x1, int v1, int x2, int v2)
        {
            var first = new Kangaroo(v1, x1);
            var second = new Kangaroo(v2, x2);

            var bigger = first.CurrentPosition > second.CurrentPosition ? first : second;
            var smaller = first.CurrentPosition > second.CurrentPosition ? second : first;

            if (bigger.JumpRate >= smaller.JumpRate) return false;

            while (bigger.CurrentPosition > smaller.CurrentPosition)
            {
                bigger.Jump();
                smaller.Jump();

                if (bigger.CurrentPosition == smaller.CurrentPosition) return true;
            }

            return false;
        }

        internal class Kangaroo
        {
            public Kangaroo(int rate, int startPosition)
            {
                JumpRate = rate;
                CurrentPosition = startPosition;
            }

            public long CurrentPosition { get; private set; }
            public int JumpRate { get; }

            public void Jump()
            {
                CurrentPosition += JumpRate;
            }
        }
    }
}
