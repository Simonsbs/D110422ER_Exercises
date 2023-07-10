namespace Tests {
	public class TestsForExercises_LongestConsecutiveArray {
		[Theory]
		[InlineData(new int[] { 100, 4, 200, 1, 3, 2 }, 4)]
		[InlineData(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
		public void TestsForExercises_LongestConsecutiveArray_V1(int[] nums, int expectedResult) {
			long result = Exercises.LongestConsecutiveArray.Solution1(nums);

			Assert.Equal(expectedResult, result);
		}

		[Theory]
		[InlineData(new int[] { 100, 4, 200, 1, 3, 2 }, 4)]
		[InlineData(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
		public void TestsForExercises_LongestConsecutiveArray_V2(int[] nums, int expectedResult) {
			long result = Exercises.LongestConsecutiveArray.Solution2(nums);

			Assert.Equal(expectedResult, result);
		}

		[Theory]
		[InlineData(new int[] { 100, 4, 200, 1, 3, 2 }, 4)]
		[InlineData(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
		public void TestsForExercises_LongestConsecutiveArray_V3(int[] nums, int expectedResult) {
			long result = Exercises.LongestConsecutiveArray.Solution3(nums);

			Assert.Equal(expectedResult, result);
		}
	}
}