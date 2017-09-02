using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    [TestFixture]
    public class _04_Kangaroo_Test : BaseFixture
    {
        //public override string StdIn => "0 3 4 2\r\n";

        //public override string ExpectedStdOut => "YES";


        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("0 3 4 2\r\n", "YES");
        }

        protected override void RunLogic()
        {
            _04_Kangaroo.Main();
        }
    }
}
