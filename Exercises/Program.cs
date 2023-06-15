using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises {
	public class Program {
		static void Main(string[] args) {
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

		public static int RomanToInt(string input) {
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

		public static int RomanToInt2(string input) {
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
