using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _08_Sock_merchant_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("9\r\n10 20 20 10 10 30 50 10 20\r\n", "3");
        }

        protected override void RunLogic()
        {
            _08_Sock_merchant.Main();
        }
    }
}
