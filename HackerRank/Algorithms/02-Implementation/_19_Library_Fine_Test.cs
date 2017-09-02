using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _19_Library_Fine_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("9 6 2015\r\n6 6 2015\r\n", "45\r\n");
        }

        protected override void RunLogic()
        {
            _19_Library_Fine.Main();
        }
    }
}
