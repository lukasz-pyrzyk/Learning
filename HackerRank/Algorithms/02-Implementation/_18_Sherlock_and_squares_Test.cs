using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _18_Sherlock_and_squares_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("2\r\n3 9\r\n17 24\r\n", "2\r\n0\r\n");
        }

        protected override void RunLogic()
        {
            _18_Sherlock_and_squares.Main();
        }
    }
}
