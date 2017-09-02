using System;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/bigger-is-greater
    /// </summary>
    class _28_Bigger_is_greater
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char[] word = Console.ReadLine().ToCharArray();

                bool available = false;
                for (int j = 0; j < word.Length - 1; j++)
                {
                    if (word[j] < word[j + 1]) available = true;
                }

                if (available)
                {
                    NextPermutation(word);

                    Console.WriteLine(word);
                }
                else
                {
                    Console.WriteLine("no answer");
                }
            }
        }

        /// <summary>
        /// https://www.nayuki.io/page/next-lexicographical-permutation-algorithm
        /// </summary>
        /// <returns></returns>
        public static bool NextPermutation(char[] array)
        {
            // Find non-increasing suffix
            int i = array.Length - 1;
            while (i > 0 && array[i - 1] >= array[i])
                i--;
            if (i <= 0)
                return false;

            // Find successor to pivot
            int j = array.Length - 1;
            while (array[j] <= array[i - 1])
                j--;
            char temp = array[i - 1];
            array[i - 1] = array[j];
            array[j] = temp;

            // Reverse suffix
            j = array.Length - 1;
            while (i < j)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
            return true;
        }
    }
}
