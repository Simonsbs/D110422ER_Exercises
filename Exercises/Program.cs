using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises {
	internal class Program {
		static void Main(string[] args) {
			string test1 = "III";
			string test2 = "V";
			string test3 = "VI";
			string test4 = "IV";
			string test5 = "LVIII";
			string test6 = "MCMXCIV";

			int result1 = RomanToInt2(test1);
			Console.WriteLine($"{test1} => {result1}{Environment.NewLine}");

			int result2 = RomanToInt2(test2);
			Console.WriteLine($"{test2} => {result2}{Environment.NewLine}");

			int result3 = RomanToInt2(test3);
			Console.WriteLine($"{test3} => {result3}{Environment.NewLine}");

			int result4 = RomanToInt2(test4);
			Console.WriteLine($"{test4} => {result4}{Environment.NewLine}");

			int result5 = RomanToInt2(test5);
			Console.WriteLine($"{test5} => {result5}{Environment.NewLine}");

			int result6 = RomanToInt2(test6);
			Console.WriteLine($"{test6} => {result6}{Environment.NewLine}");
		}

		static Dictionary<char, int> hashRomanChars = new Dictionary<char, int>() {
			{'I', 1 },
			{'V', 5 },
			{'X', 10 },
			{'L', 50 },
			{'C', 100 },
			{'D', 500 },
			{'M', 1000 }
		};

		static int RomanToInt(string input) {
			int result = 0;
			int lastValue = 0;
			for (int i = input.Length - 1; i >= 0; i--) {
				char currentNumeral = input[i];
				int currentValue = hashRomanChars[currentNumeral];

				if (lastValue > currentValue) {
					currentValue *= -1;
				}

				lastValue = currentValue;

				result += currentValue;
			}

			return result;

		}

		static int RomanToInt2(string input) {
			int result = 0;

			input = input.Replace("IV", "IIII");
			input = input.Replace("IX", "VIIII");
			input = input.Replace("XL", "XXXX");
			input = input.Replace("XC", "LXXXX");
			input = input.Replace("CD", "CCCC");
			input = input.Replace("CM", "DCCCC");

			foreach (char c in input) {
				result += hashRomanChars[c];
			}

			return result;
		}
	}
}
