using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests {

	public class TestsForEX2_CheckBrackets1 {
		[Theory]
		[InlineData("()")]
		[InlineData("[]")]
		[InlineData("(]", false)]
		[InlineData("([<])", false)]
		[InlineData("({[<>]})")]
		public void TestsForEX2_CheckBrackets1_NoBonus(string valueToTest, bool expectedResult = true) {
			//string valueToTest = "()";

			bool result = Exercises.EX2.CheckBrackets1(valueToTest);

			Assert.Equal(result, expectedResult);
		}

		[Theory]
		[InlineData("asd(asd)asd")]
		[InlineData("asd[asd]asd")]
		[InlineData("asd(asd]asd", false)]
		[InlineData("(asd[<asd]asd)asd", false)]
		[InlineData("asd123!@#(asd{[<asd>]}asd)asd")]
		public void TestsForEX2_CheckBrackets1_Bonus(string valueToTest, bool expectedResult = true) {
			//string valueToTest = "()";

			bool result = Exercises.EX2.CheckBrackets1_WithBonus(valueToTest);

			Assert.Equal(result, expectedResult);
		}
	}
}
