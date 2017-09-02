using System;
using System.Collections.Generic;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/find-digits
    /// </summary>
    class _15_Find_digits
    {
        public static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                var numbers = GetNumbers(n);

                int count = 0;
                foreach (int number in numbers)
                {
                    if (n%number == 0) count++;
                }

                Console.WriteLine(count);
            }
        }

        private static Stack<int> GetNumbers(int n)
        {
            var numbers = new Stack<int>();

            while (n > 0)
            {
                int r = n % 10;
                if(r != 0) numbers.Push(r);
                n /= 10;
            }

            return numbers;
        }
    }
}
