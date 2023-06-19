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
		public void TestsForEX2_CheckBrackets1_Check1(string valueToTest, bool expectedResult = true) {
			//string valueToTest = "()";

			bool result = Exercises.EX2.CheckBrackets(valueToTest);

			Assert.Equal(result, expectedResult);
		}
	}
}
