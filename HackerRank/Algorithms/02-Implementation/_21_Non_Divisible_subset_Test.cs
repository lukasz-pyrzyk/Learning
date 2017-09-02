using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _21_Non_Divisible_subset_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("4 3\r\n1 7 2 4\r\n", "3\r\n");
            yield return new TestData("5 5\r\n2 7 12 17 22\r\n", "5\r\n");
            yield return new TestData("10 5\r\n770528134 663501748 384261537 800309024 103668401 538539662 385488901 101262949 557792122 46058493\r\n", "6\r\n");
        }

        protected override void RunLogic()
        {
            _21_Non_Divisible_subset.Main();
        }
    }
}
