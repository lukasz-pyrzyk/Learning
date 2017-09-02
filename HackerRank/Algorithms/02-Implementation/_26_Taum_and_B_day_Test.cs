using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _26_Taum_and_B_day_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("5\r\n"
+ "10 10\r\n"
+ "1 1 1\r\n"
+ "5 9\r\n"
+ "2 3 4\r\n"
+ "3 6\r\n"
+ "9 1 1\r\n"
+ "7 7\r\n"
+ "4 2 1\r\n"
+ "3 3\r\n"
+ "1 9 2\r\n",
"20\r\n"
+ "37\r\n"
+ "12\r\n"
+ "35\r\n"
+ "12\r\n");
        }

        protected override void RunLogic()
        {
            _26_Taum_and_B_day.Main();
        }
    }
}
