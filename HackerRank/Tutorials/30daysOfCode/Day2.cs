using System;

namespace _30daysOfCode
{
    public class Day2
    {
        public static void Main()
        {
            decimal mealCost = Convert.ToDecimal(Console.ReadLine());
            int tipPercent = Convert.ToInt32(Console.ReadLine());
            int taxPercent = Convert.ToInt32(Console.ReadLine());

            decimal tip = mealCost * (decimal)(tipPercent / (double)100);
            decimal tax = mealCost * (decimal)(taxPercent / (double)100);
            decimal sum = mealCost + tip + tax;

            Console.WriteLine("The total meal cost is " + sum.ToString("0") +" dollars.");
        }
    }
}
