namespace Tests {
	public class TestsForEX6_LongestPalindromSubstring {
		[Theory]
		[InlineData("racecar", "racecar")]
		[InlineData("abcdef", "a")]
		[InlineData("a", "a")]
		[InlineData("acdfdcabbbaccc", "acdfdca")]
		[InlineData("babad", "bab")]
		[InlineData("cbbd", "bb")]
		public void TestsForEX6_LongestPalindromSubstring_V1(string valueToTest, string expectedResult) {
			string result = Exercises.LongestPalindromSubstring.Solution1(valueToTest);

			Assert.Equal(result, expectedResult);
		}


		[Theory]
		[InlineData("racecar", "racecar")]
		[InlineData("abcdef", "f")]
		[InlineData("a", "a")]
		[InlineData("acdfdcabbbaccc", "cabbbac")]
		[InlineData("babad", "aba")]
		[InlineData("cbbd", "bb")]
		public void TestsForEX6_LongestPalindromSubstring_V2(string valueToTest, string expectedResult) {
			string result = Exercises.LongestPalindromSubstring.Solution2(valueToTest);

			Assert.Equal(result, expectedResult);
		}


		[Theory]
		[InlineData("racecar", "racecar")]
		[InlineData("abcdef", "a")]
		[InlineData("a", "a")]
		[InlineData("acdfdcabbbaccc", "acdfdca")]
		[InlineData("babad", "bab")]
		[InlineData("cbbd", "bb")]
		public void TestsForEX6_LongestPalindromSubstring_V3(string valueToTest, string expectedResult) {
			string result = Exercises.LongestPalindromSubstring.Solution3(valueToTest);

			Assert.Equal(result, expectedResult);
		}
	}
}
