using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _30daysOfCode
{
    [TestFixture]
    public class Day28_Test : BaseFixture
    {
        protected override void RunLogic()
        {
            Day28.Main();
        }

        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("6\r\n" +
                                        "riya riya@gmail.com\r\n" +
                                        "julia julia@julia.me\r\n" +
                                        "julia sjulia@gmail.com\r\n" +
                                        "julia julia@gmail.com\r\n" +
                                        "samantha samantha@gmail.com\r\n" +
                                        "tanya tanya@gmail.com",

                                        "julia\r\n" +
                                        "julia\r\n" +
                                        "riya\r\n" +
                                        "samantha\r\n" +
                                        "tanya\r\n");
        }
    }
}
