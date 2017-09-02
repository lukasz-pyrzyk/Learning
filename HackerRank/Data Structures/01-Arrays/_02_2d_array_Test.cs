using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _01_Arrays
{
    [TestFixture]
    public class _02_2d_array_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("1 1 1 0 0 0\r\n0 1 0 0 0 0\r\n1 1 1 0 0 0\r\n0 0 2 4 4 0\r\n0 0 0 2 0 0\r\n0 0 1 2 4 0\r\n", "19");
        }

        protected override void RunLogic()
        {
            _02_2d_array.Main();
        }
    }
}
