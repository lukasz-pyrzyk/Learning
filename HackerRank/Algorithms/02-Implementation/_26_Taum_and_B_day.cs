using System;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/taum-and-bday
    /// </summary>
    class _26_Taum_and_B_day
    {
        public static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_b = Console.ReadLine().Split(' ');
                long blackCount = Convert.ToInt64(tokens_b[0]);
                long whiteCount = Convert.ToInt64(tokens_b[1]);
                string[] tokens_x = Console.ReadLine().Split(' ');
                long blackPrice = Convert.ToInt64(tokens_x[0]);
                long whitePrice = Convert.ToInt64(tokens_x[1]);
                long paintingPrice = Convert.ToInt64(tokens_x[2]);

                long sum = 0;
                sum += CalculateCostofGifts(whitePrice, blackPrice, paintingPrice, blackCount);
                sum += CalculateCostofGifts(blackPrice, whitePrice, paintingPrice, whiteCount);

                Console.WriteLine(sum);
            }
        }

        private static long CalculateCostofGifts(long whitePrice, long blackPrice, long paintingPrice, long blackCount)
        {
            if (PaintingIsCheaper(whitePrice, blackPrice, paintingPrice))
            {
                return BuyAndPaint(blackCount, whitePrice, paintingPrice);
            }

            return Buy(blackCount, blackPrice);
        }

        private static long Buy(long count, long price)
        {
            return count * price;
        }

        private static long BuyAndPaint(long count, long price, long paintingCost)
        {
            return Buy(count, price) + count * paintingCost;
        }

        private static bool PaintingIsCheaper(long currentPrice, long anotherPrice, long paintingCost)
        {
            return currentPrice + paintingCost < anotherPrice;
        }
    }
}
