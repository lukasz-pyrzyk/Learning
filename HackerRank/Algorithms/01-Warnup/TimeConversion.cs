using System;
using System.Collections.Generic;
using BaseTestFixture;

namespace _01_Warnup
{
    class TimeConversion
    {
        public static void Main()
        {
            string time = Console.ReadLine();
            DateTime date = DateTime.Parse(time);
            Console.Write(date.ToString("HH:mm:ss"));
        }
    }

    public class TimeConversionTests : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("07:05:45PM", "19:05:45");
        }

        protected override void RunLogic()
        {
            TimeConversion.Main();
        }
    }
}
