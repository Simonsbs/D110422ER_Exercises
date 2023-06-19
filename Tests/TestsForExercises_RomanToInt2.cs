using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Tests {
	public class TestsForExercises_RomanToInt2 {
		[Fact]
		public void Exercises_RomanToInt2_TestIfResponseIs3() {
			string valueToTest = "III";

			int result = Exercises.EX1.RomanToInt2(valueToTest);

			Assert.Equal(3, result);
		}

		[Fact]
		public void Exercises_RomanToInt2_TestIfResponseIs5() {
			string valueToTest = "V";

			int result = Exercises.EX1.RomanToInt2(valueToTest);

			Assert.Equal(5, result);
		}

		[Fact]
		public void Exercises_RomanToInt2_TestIfResponseIs6() {
			string valueToTest = "VI";

			int result = Exercises.EX1.RomanToInt2(valueToTest);

			Assert.Equal(6, result);
		}

		[Fact]
		public void Exercises_RomanToInt2_TestIfResponseIs4() {
			string valueToTest = "IV";

			int result = Exercises.EX1.RomanToInt2(valueToTest);

			Assert.Equal(4, result);
		}

		[Fact]
		public void Exercises_RomanToInt2_TestIfResponseIs58() {
			string valueToTest = "LVIII";

			int result = Exercises.EX1.RomanToInt2(valueToTest);

			Assert.Equal(58, result);
		}

		[Fact]
		public void Exercises_RomanToInt2_TestIfResponseIs1994() {
			string valueToTest = "MCMXCIV";

			int result = Exercises.EX1.RomanToInt2(valueToTest);

			Assert.Equal(1994, result);
		}
	}
}