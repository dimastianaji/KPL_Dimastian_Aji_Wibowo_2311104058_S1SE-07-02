using Microsoft.VisualStudio.TestTools.UnitTesting;
using modul12_123456;
using modul12_2311104058;

namespace modul12_123456.Tests
{
    [TestClass]
    public class PangkatTests
    {
        [TestMethod]
        public void Test_B_Equals_0_ShouldReturn_1()
        {
            int result = PangkatHelper.CariNilaiPangkat(5, 0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test_B_Negative_ShouldReturn_Minus1()
        {
            int result = PangkatHelper.CariNilaiPangkat(4, -2);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Test_B_More_Than_10_ShouldReturn_Minus2()
        {
            int result = PangkatHelper.CariNilaiPangkat(4, 11);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Test_A_More_Than_100_ShouldReturn_Minus2()
        {
            int result = PangkatHelper.CariNilaiPangkat(101, 2);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Test_Normal_Case_ShouldReturn_CorrectPower()
        {
            int result = PangkatHelper.CariNilaiPangkat(2, 3); 
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Test_Overflow_ShouldReturn_Minus3()
        {
            int result = PangkatHelper.CariNilaiPangkat(100, 10); 
            Assert.AreEqual(-3, result);
        }
    }
}
