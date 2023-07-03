using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises {
	public static class LongestPalindromSubstring {
		public static string Solution1(string s) {
			if (string.IsNullOrEmpty(s)) {
				return string.Empty;
			}

			string longestSoFar = string.Empty;

			for (int i = 0; i < s.Length; i++) {
				for (int j = i + 1; j <= s.Length; j++) {
					string subStr = s.Substring(i, j - i);
					string reversedStr = new String(subStr.Reverse().ToArray());

					if (subStr == reversedStr && subStr.Length > longestSoFar.Length) {
						longestSoFar = subStr;
					}
				}
			}

			return longestSoFar;
		}


		public static string Solution2(string s) {
			if (string.IsNullOrEmpty(s)) {
				return string.Empty;
			}

			int start = 0;
			int end = 0;

			for (int i = 0; i < s.Length; i++) {
				int len1 = Expander(s, i, i);
				int len2 = Expander(s, i, i + 1);
				int len = Math.Max(len1, len2);

				if (len > (end - start)) {
					start = i - (len - 1) / 2;
					end = i + len / 2;
				}
			}

			return s.Substring(start, end - start + 1);
		}

		private static int Expander(string s, int left, int right) {
			int Left = left;
			int Right = right;

			while (Left >= 0 && Right < s.Length && s[Left] == s[Right]) {
				Left--;
				Right++;
			}

			return Right - Left - 1;
		}


		// Thanks to Mohamed
		public static string Solution3(string str) {
			string s, temp = "";
			if (str == null || str.Length == 0)
				return "";

			if (Reverse(str) == str)
				return str;

			string maxString = str[0].ToString();

			for (int i = 0; i < str.Length; i++) {
				s = "";
				for (int j = i; j < str.Length; j++) {
					s += str[j];
					temp = Reverse(s);
					if (temp == s && temp.Length > maxString.Length)
						maxString = temp;

				}

			}

			return maxString;
		}

		public static string Reverse(string str) {
			StringBuilder sb = new StringBuilder();
			for (int i = str.Length - 1; i >= 0; i--) {
				sb.Append(str[i]);
			}
			return sb.ToString();
		}
	}
}
