using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _13_Save_the_prisoner_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("1\r\n5 2 1\r\n", "2\r\n");
            yield return new TestData("1\r\n5 6 1\r\n", "1\r\n");
            yield return new TestData("1\r\n5 7 1\r\n", "2\r\n");
            yield return new TestData("1\r\n5 1 1\r\n", "1\r\n");
            yield return new TestData("1\r\n5 5 1\r\n", "5\r\n");
            yield return new TestData("1\r\n208526924 756265725 150817879\r\n", "72975907\r\n");
            // yield return FromFile("_13_Save_the_prisoner_in.txt", "_13_Save_the_prisoner_out.txt");
        }

        protected override void RunLogic()
        {
            _13_Save_the_prisoner.Main();
        }
    }
}
