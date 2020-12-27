using System;
using Factorial;
using NUnit.Framework;

namespace FactorialTests
{
	public class FactorialCalculatorTests
	{
		private FactorialCalculator _calculator;

		[SetUp]
		public void Setup() => _calculator = new FactorialCalculator();

		[TestCase(0, 0)]
		[TestCase(1, 1)]
		[TestCase(2, 2)]
		[TestCase(3, 6)]
		[TestCase(4, 24)]
		[TestCase(5, 120)]
		[TestCase(6, 720)]
		[TestCase(7, 5040)]
		[TestCase(8, 40320)]
		[TestCase(9, 362880)]
		[TestCase(10, 3628800)]
		[TestCase(11, 39916800)]
		[TestCase(12, 479001600)]
		public void Returns_Factorial(int value, int expectedFactorial)
		{
			var calculatedFactorial = _calculator.Factorial(value);
			Assert.AreEqual(expectedFactorial, calculatedFactorial);
		}
		
		[Test]
		public void Throws_Exception_For_Negative_Numbers()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => _calculator.Factorial(-1));
		}
	}
}