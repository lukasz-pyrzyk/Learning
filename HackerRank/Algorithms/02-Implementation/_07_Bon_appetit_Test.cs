using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _07_Bon_appetit_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("4 1\r\n3 10 2 9\r\n12\r\n", "5");
            yield return new TestData("4 1\r\n3 10 2 9\r\n2\r\n", "-5");
            yield return new TestData("4 1\r\n3 10 2 9\r\n7\r\n", "Bon Appetit");
        }

        protected override void RunLogic()
        {
            _07_Bon_appetit.Main();
        }
    }
}
