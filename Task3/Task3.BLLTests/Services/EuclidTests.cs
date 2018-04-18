using System;
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
		public void NodTest3()
		{
			const int operandA = -25;
			const int operandB = 79;
			const int expected = 1;

			var actual = Euclid.Nod(operandA, operandB, out var ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void NodOfFourNumbersTest1()
		{
			const int operandA = 78;
			const int opearandB = 294;
			const int operandC = 570;
			const int operandD = 36;

			const int expected = 6;

			var actual = Euclid.Nod(operandA, opearandB, operandC, operandD);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void NodWithArrayParamsTest1()
		{
			const int operandA = 78;
			const int opearandB = 294;
			const int operandC = 570;
			const int operandD = 36;

			const int expected = 6;


			var actual = Euclid.NodWithArrParams(operandA, opearandB, operandC, operandD);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void NodWithArrayParamsTest2()
		{
			const int argument = 99;

			try
			{
				Euclid.NodWithArrParams(argument);
			}
			catch (ArgumentException e)
			{
				Assert.AreEqual("System.ArgumentException", e.GetType().ToString());
			}
		}

		[TestMethod()]
		public void NodWithArrayParamsTest3()
		{
			const int operandA = -539;
			const int opearandB = 567;
			const int operandC = 269;

			const int expected = 7;

			var actual = Euclid.NodWithArrParams(out var ticks, operandA, opearandB, operandC);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void BinaryNodTest1()
		{
			const int operandOne = 48;
			const int operandTwo = 64;
			const int expected = 16;

			var actual = Euclid.BinaryNod(operandOne, operandTwo);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void BinaryNodTest2()
		{
			const int operandOne = 259;
			const int operandTwo = 513;
			const int expected = 1;

			var actual = Euclid.BinaryNod(operandOne, operandTwo, out var ticks);
			Assert.AreEqual(expected, actual);
		}
	}
}