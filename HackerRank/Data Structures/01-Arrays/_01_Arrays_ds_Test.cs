using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _01_Arrays
{
    [TestFixture]
    public class _01_Arrays_ds_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("4\r\n1 4 3 2\r\n", "2 3 4 1");
        }

        protected override void RunLogic()
        {
            _01_Arrays_ds.Main();
        }
    }
}
