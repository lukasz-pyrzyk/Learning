using System;
using System.Collections.Generic;
using System.Linq;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/two-pluses
    /// </summary>
    public class EmasSupercomputer
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine().Split(' ');
            int n = int.Parse(firstLine[0]);
            int m = int.Parse(firstLine[1]);
            byte[,] grid = new byte[n, m];

            for (int i = 0; i < n; i++)
            {
                var dataLine = Console.ReadLine().ToCharArray();
                for (int j = 0; j < m; j++)
                {
                    grid[i, j] = dataLine[j] == 'G' ? (byte)1 : (byte)0;
                }
            }

            int result = GetResult(grid, n, m);

            Console.WriteLine(result);
        }

        private static List<Point> getCrossOfSize(int size)
        {
            var result = new List<Point>();
            for (int i = -size; i <= size; i++)
            {
                result.Add(new Point(i, 0));
                result.Add(new Point(0, i));
            }

            return result;
        }

        private static bool DoesItFir(Cross cross, byte[,] grid)
        {
            foreach (Point point in cross.Mater)
            {
                if (grid[point.x, point.y] == 0)
                    return false;
            }

            return true;
        }

        private static bool areOverlapping(Cross a, Cross b)
        {
            return a.Mater.Any(x => b.Mater.Contains(x));
        }

        private static int GetResult(byte[,] grid, int width, int height)
        {
            int smaller = Math.Min(width, height);
            if (smaller % 2 == 0)
                smaller--;
            int crossSize = smaller / 2;

            var crossSizes = new List<Cross>();

            for (; crossSize >= 0; crossSize--)
            {
                for (int i = crossSize; i < width - crossSize; i++)
                {
                    for (int j = crossSize; j < height - crossSize; j++)
                    {
                        var cross = new Cross(crossSize, new Point(i, j));
                        if (DoesItFir(cross, grid))
                        {
                            crossSizes.Add(cross);
                        }
                    }
                }
            }

            var pairs = new List<int>();
            for (int i = 0; i < crossSizes.Count; i++)
            {
                for (int j = i + 1; j < crossSizes.Count; j++)
                {
                    if (!areOverlapping(crossSizes[i], crossSizes[j]))
                    {
                        pairs.Add(crossSizes[i].Area * crossSizes[j].Area);
                    }
                }
            }

            return pairs.Max();
        }

        struct Point
        {
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int x { get; }
            public int y { get; }

            public Point Add(Point middle)
            {
                return new Point(x + middle.x, y + middle.y);
            }

            public override string ToString() => $"X: {x}, Y: {y}";
        }

        class Cross
        {
            public Cross(int radius, Point middle)
            {
                Radius = radius;
                Middle = middle;
                Mater = Materialize();
                Area = Radius * 4 + 1;
            }

            public int Radius { get; }
            public Point Middle { get; }
            public Point[] Mater { get; }
            public int Area { get; }

            private Point[] Materialize()
            {
                var cross = getCrossOfSize(Radius);
                return cross.Select(x => x.Add(Middle)).ToArray();
            }
        }


        [TestFixture]
        public class EmasSupercomputerTests : BaseFixture
        {
            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("5 6\r\nGGGGGG\r\nGBBBGB\r\nGGGGGG\r\nGGBBGB\r\nGGGGGG\r\n", "5\r\n");
                yield return new TestData("6 6\r\nBGBBGB\r\nGGGGGG\r\nBGBBGB\r\nGGGGGG\r\nBGBBGB\r\nBGBBGB\r\n", "25\r\n");
                yield return new TestData(
"13 14\r\n" +
"GBBGGBGGBBGGGB\r\n" +
"GBBGGBGGBBGGGB\r\n" +
"GBBGGBGGBBGGGB\r\n" +
"GBBGGBGGBBGGGB\r\n" +
"GGGGGGGGGGGGGG\r\n" +
"GBBGGBGGBBGGGB\r\n" +
"GGGGGGGGGGGGGG\r\n" +
"GBBGGBGGBBGGGB\r\n" +
"GBBGGBGGBBGGGB\r\n" +
"GGGGGGGGGGGGGG\r\n" +
"GGGGGGGGGGGGGG\r\n" +
"GGGGGGGGGGGGGG\r\n" +
"GBBGGBGGBBGGGB\r\n", "225\r\n");
            }

            protected override void RunLogic()
            {
                Main();
            }
        }
    }
}