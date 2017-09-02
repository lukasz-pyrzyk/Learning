using System;

namespace _01_Warnup
{
    class DiagonalDifference
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int primary = PrimaryDiagonal(a);
            int secondary = SecondaryDiagonal(a);

            Console.WriteLine(Math.Abs(primary - secondary));
        }

        private static int SecondaryDiagonal(int[][] a)
        {
            int sum = 0;
            int temp = a.Length - 1;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i][temp--];
            }

            return sum;
        }

        private static int PrimaryDiagonal(int[][] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i][i];
            }

            return sum;
        }
    }
}
