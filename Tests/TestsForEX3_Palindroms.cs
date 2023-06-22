using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests {
	public class TestsForEX3_Palindroms {
		[Theory]
		[InlineData(12321)]
		[InlineData(121)]
		[InlineData(2248422)]
		[InlineData(-121, false)]
		[InlineData(10, false)]
		[InlineData(123321)]
		public void TestsForEX3_IsPalindrom_V1(int valueToTest, bool expectedResult = true) {
			bool result = Exercises.EX3.IsPalindrom(valueToTest);

			Assert.Equal(result, expectedResult);
		}


		[Theory]
		[InlineData(12321)]
		[InlineData(121)]
		[InlineData(2248422)]
		[InlineData(-121, false)]
		[InlineData(10, false)]
		[InlineData(123321)]
		public void TestsForEX3_IsPalindrom_V2(int valueToTest, bool expectedResult = true) {
			bool result = Exercises.EX3.IsPalindrom2(valueToTest);

			Assert.Equal(result, expectedResult);
		}

		[Theory]
		[InlineData(12321)]
		[InlineData(121)]
		[InlineData(2248422)]
		[InlineData(-121, false)]
		[InlineData(10, false)]
		[InlineData(123321)]
		public void TestsForEX3_IsPalindrom_V3(int valueToTest, bool expectedResult = true) {
			bool result = Exercises.EX3.IsPalindrom3(valueToTest);

			Assert.Equal(result, expectedResult);
		}
	}
}
