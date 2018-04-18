using System.Net.NetworkInformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3.BLL.Services;

namespace Task3.BLLTests.Services
{
    [TestClass()]
    public class EuclidTests
    {
        [TestMethod()]
        public void NodTest1()
        {
            const int operandOne = 48;
            const int operandTwo = 64;
            const int expected = 16;

            var actual = Euclid.Nod(operandOne, operandTwo);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NodTest2()
        {
            const int operandA = 661;
            const int operandB = 113;
            const int expected = 1;

            var actual = Euclid.Nod(operandA, operandB);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NodFourTest1()
        {
            const int operandA = 78;
            const int opearandB = 294;
            const int operandC = 570;
            const int operandD = 36;

            const int expected = 6;

            var actual = Euclid.Nod(operandA, opearandB, operandC, operandD);
            Assert.AreEqual(expected, actual);
        }
    }
}