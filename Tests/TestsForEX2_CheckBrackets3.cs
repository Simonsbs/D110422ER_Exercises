using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests {
	public class TestsForEX2_CheckBrackets3 {
		[Theory]
		[InlineData("()")]
		[InlineData("[]")]
		[InlineData("(]", false)]
		[InlineData("([<])", false)]
		[InlineData("({[<>]})")]
		[InlineData("{(})", false)]
		public void TestsForEX2_CheckBrackets3_NoBonus(string valueToTest, bool expectedResult = true) {
			//string valueToTest = "()";

			bool result = Exercises.EX2.CheckBrackets3(valueToTest);

			Assert.Equal(result, expectedResult);
		}

		[Theory]
		[InlineData("asd(asd)asd")]
		[InlineData("asd[asd]asd")]
		[InlineData("asd(asd]asd", false)]
		[InlineData("(asd[<asd]asd)asd", false)]
		[InlineData("asd123!@#(asd{[<asd>]}asd)asd")]
		public void TestsForEX2_CheckBrackets3_Bonus(string valueToTest, bool expectedResult = true) {
			//string valueToTest = "()";

			bool result = Exercises.EX2.CheckBrackets3_BONUS(valueToTest);

			Assert.Equal(result, expectedResult);
		}
	}
}
