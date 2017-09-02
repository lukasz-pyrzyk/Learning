using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _05_Sorting
{
    [TestFixture]
    public class _02_Insertion_sort1_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("5\r\n2 4 6 8 3\r\n", "2 4 6 8 8 \r\n2 4 6 6 8 \r\n2 4 4 6 8 \r\n2 3 4 6 8 \r\n");
            yield return new TestData("10\r\n2 3 4 5 6 7 8 9 10 1\r\n", "2 3 4 5 6 7 8 9 10 10 \r\n" +
                                                                        "2 3 4 5 6 7 8 9 9 10 \r\n" +
                                                                        "2 3 4 5 6 7 8 8 9 10 \r\n" +
                                                                        "2 3 4 5 6 7 7 8 9 10 \r\n" +
                                                                        "2 3 4 5 6 6 7 8 9 10 \r\n" +
                                                                        "2 3 4 5 5 6 7 8 9 10 \r\n" +
                                                                        "2 3 4 4 5 6 7 8 9 10 \r\n" +
                                                                        "2 3 3 4 5 6 7 8 9 10 \r\n" +
                                                                        "2 2 3 4 5 6 7 8 9 10 \r\n" +
                                                                        "1 2 3 4 5 6 7 8 9 10 \r\n");
        }

        protected override void RunLogic()
        {
            _02_Insertion_sort1.Main();
        }
    }
}
