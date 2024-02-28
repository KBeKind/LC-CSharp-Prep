using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
	[TestClass]
	public class BalancedBracketsTests
	{
		// TODO: Add tests to this file.

		[TestMethod]
		public void OnlyBracketsReturnsTrue()
		{
			Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
		}

		[TestMethod]
		public void OnlyOneBracketReturnsFalse()
		{
			Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
		}

		[TestMethod]
		public void TwoOpenBracketsReturnsFalse()
		{
			Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[["));
		}


		[TestMethod]
		public void TwoBracketsInWrongOrderReturnsFalse()
		{
			Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
		}


		[TestMethod]
		public void TwoOpenBracketsOneCloseReturnsFalse()
		{
			Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[]"));
		}

		[TestMethod]
		public void OpenThenCloseThenOpenReturnsFalse()
		{
			Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]["));
		}

		[TestMethod]
		public void NestedBracketsReturnsTrue()
		{
			Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[]]]"));
		}


		[TestMethod]
		public void NoBracketsReturnsTrue()
		{
			Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
		}

		[TestMethod]
		public void NestedUnBalancedBracketsReturnsFalse()
		{
			Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[][]"));
		}

	}
}