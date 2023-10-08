
using System.IO;
using System;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {

        private const string Expected = "testing hwllorold";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                CICDPipeline.Program.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }

        }
    }
}