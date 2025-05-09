using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGrade()
        {
            String? result1 = praktikummodul12.Program.DetermineGrade(90);
            assert.AreEqual("A", result1);

            String? result2 = praktikummodul12.Program.DetermineGrade(80);
            assert.AreEqual("A", result2);

            String? result3 = praktikummodul12.Program.DetermineGrade(70);
            assert.AreEqual("", result3);

            String? result4 = praktikummodul12.Program.DetermineGrade(30);
            assert.AreEqual("", result4);

            String? result5 = praktikummodul12.Program.DetermineGrade(-1);
            assert.IsNull(result5);
        }
    }
}
