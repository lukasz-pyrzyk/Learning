namespace BaseTestFixture
{
    public struct TestData
    {
        public TestData(string stdIn, string stdOut)
        {
            StdIn = stdIn;
            StdOut = stdOut;
        }

        public string StdIn { get; }
        public string StdOut { get; }

        public override string ToString()
        {
            return StdIn + StdOut;
        }
    }
}
