using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises {
	public static class EX3 {
		//	12321
		public static bool IsPalindrom(int value) {
			if (value < 0 || (value % 10 == 0 && value != 0)) {
				return false;
			}

			int flipedValue = 0;

			while (value > flipedValue) {
				//   1 | 2
				int valueLastDigit = value % 10;

				//  0 | 10
				flipedValue = flipedValue * 10;

				// 1 | 12
				flipedValue = flipedValue + valueLastDigit;

				// 1232 | 123
				value = value / 10;
			}

			return flipedValue == value || value == (flipedValue / 10);
		}

		public static bool IsPalindrom2(int value) {
			string str = value.ToString();

			int left = 0;
			int right = str.Length - 1;

			while (left < right) {
				if (str[left] != str[right]) {
					return false;
				}

				left++;
				right--;
			}

			return true;
		}

		public static bool IsPalindrom3(int value) {
			string str = value.ToString();
			char[] strArr = str.ToCharArray();
			Array.Reverse(strArr);
			return str == new string(strArr);
		}
	}
}
