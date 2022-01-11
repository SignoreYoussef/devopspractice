using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World! from tribal";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleApp3.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}