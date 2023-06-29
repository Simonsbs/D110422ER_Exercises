using System;

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

	}
}
