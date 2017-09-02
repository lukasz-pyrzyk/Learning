using System;

namespace _02_Implementation
{
    class _02_DesignerPDFViewer
    {
        public static void Main()
        {
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] h = Array.ConvertAll(h_temp, int.Parse);
            string word = Console.ReadLine();

            int max = 0;
            foreach (char c in word)
            {
                int position = c - 'a';
                int height = h[position];

                if (height > max) max = height;
            }

            Console.Write(max * word.Length);
        }
    }
}
