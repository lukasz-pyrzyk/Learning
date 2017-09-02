using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _11_Beautiful_days_at_the_movies_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("20 23 6\r\n", "2");
        }

        protected override void RunLogic()
        {
            _11_Beautiful_days_at_the_movies.Main();
        }
    }
}
