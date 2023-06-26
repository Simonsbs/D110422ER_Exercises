using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests {
	public class TestsFor_SearchAlgorithms {
		[Theory]
		[InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 8, 7)]
		[InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, 2)]
		[InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 11, -1)]
		public void TestsFor_SearchAlgorithms_BinarySearch(int[] valueToTest, int target, int expectedResult) {
			int result = Exercises.SearchAlgorithms.BinarySearch(valueToTest, target);

			Assert.Equal(result, expectedResult);
		}
	}
}
