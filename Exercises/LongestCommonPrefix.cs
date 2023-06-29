using System;
using System.Linq;

namespace Exercises {
	public static class LongestCommonPrefix {

		// ["floor", "flower", "flip"] - "fl"

		public static string Solution1(string[] strs) {
			if (strs == null || strs.Length == 0) {
				return "";
			}
			if (strs.Length == 1) {
				return strs[0];
			}

			for (int prefixLength = 0; prefixLength < strs[0].Length; prefixLength++) {
				char c = strs[0][prefixLength];
				for (int i = 1; i < strs.Length; i++) {
					if (prefixLength >= strs[i].Length || strs[i][prefixLength] != c) {
						return strs[i].Substring(0, prefixLength);
					}
				}
			}

			return strs[0];
		}

		public static string Solution2(string[] strs) {
			if (strs == null || strs.Length == 0) {
				return "";
			}
			if (strs.Length == 1) {
				return strs[0];
			}

			string minStr = strs[0];
			foreach (string str in strs) {
				if (str.Length < minStr.Length) {
					minStr = str;
				}
			}

			int low = 0;
			int high = minStr.Length;

			while (low <= high) {
				int mid = (low + high) / 2;
				//int safeMid = low + (high - low) / 2;

				string prefix = minStr.Substring(0, mid);

				if (IsCommonPrefix(strs, prefix)) {
					low = mid + 1;
				} else {
					high = mid - 1;
				}
			}

			return minStr.Substring(0, (low + high) / 2);
		}

		private static bool IsCommonPrefix(string[] strs, string prefix) {
			foreach (string str in strs) {
				if (!str.StartsWith(prefix)) {
					return false;
				}
			}

			return true;
		}




		// Thanks to Mohamad
		public static string Solution3(string[] arr) {
			if (arr.Length == 0 || arr == null)
				return "";

			if (arr.Length == 1)
				return arr[0];

			string[] newArray = Sort(arr);
			
			int min = Math.Min(newArray[0].Length, newArray[newArray.Length - 1].Length);

			string st1, st2;
			int i = 0;
			st1 = newArray[0];
			st2 = newArray[newArray.Length - 1];
			while (i < min && st1[i].CompareTo(st2[i]) == 0)
				i++;

			return newArray[0].Substring(0, i);
		}

		public static string[] Sort(string[] arr) {
			string temp;
			for (int i = 0; i < arr.Length; i++) {
				for (int j = 0; j < arr.Length - 1; j++) {
					if (arr[j].CompareTo(arr[j + 1]) > 0) {
						temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
				}
			}
			return arr;
		}


		// Thanks to Yitzhak
		public static string Solution4(string[] arr) {
			if (!arr.Any()) {
				return "";
			}

			string result = "";

			int minLength = arr.Skip(1).Aggregate(arr[0].Length, (acc, s) => Math.Min(acc, s.Length));
			
			for (int i = 0; i < minLength; i++) {
				bool allEqual = arr.Skip(1).All(x => x[i] == arr[0][i]);

				if (allEqual) {
					result += arr[0][i];
				} else {
					break;
				}
			}

			return result;
		}

		// Thanks to Yitzhak
		public static string Solution5(string[] arr) {
			if (!arr.Any()) {
				return "";
			}

			string prefix = arr[0];

			foreach (string str in arr.Skip(1)) {
				while (!str.StartsWith(prefix)) {
					prefix = prefix.Remove(prefix.Length - 1);
				}
			}

			return prefix;
		}
	}
}
