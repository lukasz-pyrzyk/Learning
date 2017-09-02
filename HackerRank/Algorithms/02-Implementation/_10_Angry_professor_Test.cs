using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _10_Angry_professor_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("2\r\n4 3\r\n-1 -3 4 2\r\n4 2\r\n0 -1 2 1\r\n", "YES\r\nNO\r\n");
        }

        protected override void RunLogic()
        {
            _10_Angry_professor.Main();
        }
    }
}
