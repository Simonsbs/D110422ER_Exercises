namespace Tests {
	public class TestsForExercises_MinimumCostArray {
		[Theory]
		[InlineData(new int[] { 1, 3, 5, 2 }, new int[] { 2, 3, 1, 14 }, 8)]
		[InlineData(new int[] { 2, 2, 2, 2, 2 }, new int[] { 4, 2, 8, 1, 3 }, 0)]
		[InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 1, 1 }, 2)]
		[InlineData(new int[] { 3, 1, 2 }, new int[] { 2, 2, 2 }, 4)]
		[InlineData(new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 }, 0)]
		[InlineData(new int[] { 5, 7, 1 }, new int[] { 2, 3, 4 }, 22)]
		[InlineData(new int[] { 2, 4, 6, 8, 10 }, new int[] { 1, 1, 1, 1, 1 }, 12)]
		public void TestsForExercises_MinimumCostArray_V1(int[] nums, int[] costs, long expectedResult) {
			long result = Exercises.MinimumCostArray.Solution1(nums, costs);

			Assert.Equal(expectedResult, result);
		}


		[Theory]
		[InlineData(new int[] { 1, 3, 5, 2 }, new int[] { 2, 3, 1, 14 }, 8)]
		[InlineData(new int[] { 2, 2, 2, 2, 2 }, new int[] { 4, 2, 8, 1, 3 }, 0)]
		[InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 1, 1 }, 2)]
		[InlineData(new int[] { 3, 1, 2 }, new int[] { 2, 2, 2 }, 4)]
		[InlineData(new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 }, 0)]
		[InlineData(new int[] { 5, 7, 1 }, new int[] { 2, 3, 4 }, 22)]
		[InlineData(new int[] { 2, 4, 6, 8, 10 }, new int[] { 1, 1, 1, 1, 1 }, 12)]
		public void TestsForExercises_MinimumCostArray_V2(int[] nums, int[] costs, long expectedResult) {
			long result = Exercises.MinimumCostArray.Solution2(nums, costs);

			Assert.Equal(expectedResult, result);
		}
	}
}