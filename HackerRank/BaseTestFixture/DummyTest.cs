using System.Collections.Generic;
using NUnit.Framework;

namespace BaseTestFixture
{
    [TestFixture]
    public class DummyTest : BaseFixture
    {
        protected override void RunLogic()
        {
        }

        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("", "");
        }
    }
}
