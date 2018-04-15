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
        public void TripleNodTest1()
        {
            const int operandOne = 9;
            const int opearandTwo = 12;
            const int operandThree = 22;
            const int expected = 4;

            var actual = 9;
            Assert.AreEqual(expected, actual);
        }
    }
}