using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests {
	public class TestsForEX2_CheckBrackets2 {
		[Theory]
		/*[InlineData("()")]
		[InlineData("[]")]
		[InlineData("(]", false)]
		[InlineData("([<])", false)]
		[InlineData("({[<>]})")]*/
		[InlineData("{(})", false)]
		public void TestsForEX2_CheckBrackets2_NoBonus(string valueToTest, bool expectedResult = true) {
			//string valueToTest = "()";

			bool result = Exercises.EX2.CheckBrackets2(valueToTest);

			Assert.Equal(result, expectedResult);
		}

		
	}
}
