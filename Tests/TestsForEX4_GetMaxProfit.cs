using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests {
	public class TestsForEX4_GetMaxProfit {
		[Fact]
		[InlineData(new[] { 8, 2, 5, 3, 6, 4 }, 4)]
		[InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
		public void TestsForEX4_GetMaxProfit_V1(int[] valueToTest, int expectedResult) {
			int result = Exercises.EX4.GetMaxProfit(valueToTest);

			Assert.Equal(result, expectedResult);
		}
	}
}
