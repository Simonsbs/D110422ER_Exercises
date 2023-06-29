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

	public class TestsFor_LongestCommonPrefix {
		[Theory]
		[InlineData(new[] { "floor", "flower", "flip" }, "fl")]
		[InlineData(new[] { "floor", "flower" }, "flo")]
		[InlineData(new[] { "flowers", "flower" }, "flower")]
		[InlineData(new[] { "cat", "dog", "frog", "donkey" }, "")]
		[InlineData(new[] { "stream", "strong", "street" }, "str")]
		[InlineData(new[] { "cat" }, "cat")]

		public void TestsFor_LongestCommonPrefix_Solution1(string[] valueToTest, string expectedResult) {
			string result = Exercises.LongestCommonPrefix.Solution1(valueToTest);

			Assert.Equal(result, expectedResult);
		}

		[Theory]
		[InlineData(new[] { "floor", "flower", "flip" }, "fl")]
		[InlineData(new[] { "floor", "flower" }, "flo")]
		[InlineData(new[] { "flowers", "flower" }, "flower")]
		[InlineData(new[] { "cat", "dog", "frog", "donkey" }, "")]
		[InlineData(new[] { "stream", "strong", "street" }, "str")]
		[InlineData(new[] { "cat" }, "cat")]

		public void TestsFor_LongestCommonPrefix_Solution2(string[] valueToTest, string expectedResult) {
			string result = Exercises.LongestCommonPrefix.Solution2(valueToTest);

			Assert.Equal(result, expectedResult);
		}

		[Theory]
		[InlineData(new[] { "floor", "flower", "flip" }, "fl")]
		[InlineData(new[] { "floor", "flower" }, "flo")]
		[InlineData(new[] { "flowers", "flower" }, "flower")]
		[InlineData(new[] { "cat", "dog", "frog", "donkey" }, "")]
		[InlineData(new[] { "stream", "strong", "street" }, "str")]
		[InlineData(new[] { "cat" }, "cat")]

		public void TestsFor_LongestCommonPrefix_Solution3(string[] valueToTest, string expectedResult) {
			string result = Exercises.LongestCommonPrefix.Solution3(valueToTest);

			Assert.Equal(result, expectedResult);
		}

		[Theory]
		[InlineData(new[] { "floor", "flower", "flip" }, "fl")]
		[InlineData(new[] { "floor", "flower" }, "flo")]
		[InlineData(new[] { "flowers", "flower" }, "flower")]
		[InlineData(new[] { "cat", "dog", "frog", "donkey" }, "")]
		[InlineData(new[] { "stream", "strong", "street" }, "str")]
		[InlineData(new[] { "cat" }, "cat")]

		public void TestsFor_LongestCommonPrefix_Solution4(string[] valueToTest, string expectedResult) {
			string result = Exercises.LongestCommonPrefix.Solution4(valueToTest);

			Assert.Equal(result, expectedResult);
		}

		[Theory]
		[InlineData(new[] { "floor", "flower", "flip" }, "fl")]
		[InlineData(new[] { "floor", "flower" }, "flo")]
		[InlineData(new[] { "flowers", "flower" }, "flower")]
		[InlineData(new[] { "cat", "dog", "frog", "donkey" }, "")]
		[InlineData(new[] { "stream", "strong", "street" }, "str")]
		[InlineData(new[] { "cat" }, "cat")]

		public void TestsFor_LongestCommonPrefix_Solution5(string[] valueToTest, string expectedResult) {
			string result = Exercises.LongestCommonPrefix.Solution5(valueToTest);

			Assert.Equal(result, expectedResult);
		}
	}
}
