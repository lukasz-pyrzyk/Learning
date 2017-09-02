using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _27_Encryption_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("haveaniceday\r\n", "hae and via ecy");
            yield return new TestData("feedthedog\r\n", "fto ehg ee dd");
            yield return new TestData("chillout\r\n", "clu hlt io");
        }

        protected override void RunLogic()
        {
            _27_Encryption.Main();
        }
    }
}
