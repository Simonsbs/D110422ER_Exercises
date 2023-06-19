using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercises {
	public class EX2 {
		public static bool CheckBrackets1(string value) {
			while (value.Contains("()") ||
				value.Contains("{}") ||
				value.Contains("[]") ||
				value.Contains("<>")) {

				value = value.Replace("()", "");
				value = value.Replace("{}", "");
				value = value.Replace("[]", "");
				value = value.Replace("<>", "");
			}

			return value.Length == 0;
		}

		static char[] brackets = new char[] { '(', ')', '{', '}', '[', ']', '<', '>' };

		public static string Filter(string value) {
			StringBuilder sb = new StringBuilder();
			foreach (char c in value) {
				if (brackets.Contains(c)) {
					sb.Append(c);
				}				
			}
			return sb.ToString();
		}

		public static string Filter_RegEx(string value) {
			return Regex.Replace(value, "[^()\\[\\]{}<>]", string.Empty);
		}

		public static bool CheckBrackets1_WithBonus(string value) {
			//value = Filter(value);
			value = Filter_RegEx(value);

			return CheckBrackets1(value);
		}

		// --------------------------------------------------------------

		static Dictionary<char, char> bracketMap = new Dictionary<char, char>() {
			{ '(',')' },
			{ '{','}' },
			{ '[',']' },
			{ '<','>' }
		};

		public static bool CheckBrackets2(string value) {
			Stack<char> openBracketsStack = new Stack<char>();

			foreach (char c in value) {
				if (bracketMap.ContainsKey(c)) {
					openBracketsStack.Push(c);
				} else {
					if (openBracketsStack.Count == 0) {
						return false;
					}

					char lastOpenedBracket = openBracketsStack.Pop();
					char buddyBracket = bracketMap[lastOpenedBracket];
					if (buddyBracket == c) {
						continue;
					}
					return false;
				}
			}

			return openBracketsStack.Count == 0;
		}
	}
}
