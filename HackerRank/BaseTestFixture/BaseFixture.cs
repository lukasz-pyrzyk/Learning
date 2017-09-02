using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

namespace BaseTestFixture
{
    [TestFixture]
    public abstract class BaseFixture
    {
        [Test]
        public void Run()
        {
            foreach (TestData data in Cases())
            {
                var writer = new StringWriter();
                Console.SetOut(writer);
                var reader = new StringReader(data.StdIn);
                Console.SetIn(reader);

                RunLogic();

                string output = writer.ToString();
                Assert.That(output, Is.EqualTo(data.StdOut));
            }
        }

        protected abstract void RunLogic();
        protected abstract IEnumerable<TestData> Cases();


        protected TestData FromFile(string input, string output)
        {
            string inputs = LoadFromTestCases(input);
            string outputs = LoadFromTestCases(output);

            return new TestData(inputs, outputs);
        }

        private static string LoadFromTestCases(string fileName)
        {
            return File.ReadAllText($"{TestContext.CurrentContext.TestDirectory}\\TestCases\\{fileName}");
        }
    }
}
