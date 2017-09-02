using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _25_Acm_icpc_team_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("4 5\r\n10101\r\n11100\r\n11010\r\n00101\r\n", "5\r\n2\r\n");
        }

        protected override void RunLogic()
        {
            _25_Acm_icpc_team.Main();
        }
    }
}
