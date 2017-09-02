using System;
using System.Collections.Generic;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/encryption
    /// </summary>
    class _27_Encryption
    {
        public static void Main()
        {
            string s = Console.ReadLine();

            double sqlrt = Math.Sqrt(s.Length);
            int rows = (int)Math.Floor(sqlrt);
            int columns = (int)Math.Ceiling(sqlrt);

            if (rows * columns < s.Length) rows = columns;

            var table = new char[rows, columns];

            int position = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns && position < s.Length; j++)
                {
                    char c = s[position++];
                    table[i, j] = c;
                }
            }

            for (int i = 0; i < columns;)
            {
                for (int j = 0; j < rows;)
                {
                    char c = table[j++, i];
                    if (c != '\0')
                    {
                        Console.Write(c);
                    }
                }

                i++;
                if (i != columns)
                {
                    Console.Write(' ');
                }
            }
        }
    }
}
