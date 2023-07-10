using System;
using System.Collections.Generic;

namespace Exercises {
	public static class LongestConsecutiveArray {

		// [100,4,200,1,3,2]

		public static int Solution1(int[] nums) {
			int longestStreak = 0;

			for (int i = 0; i < nums.Length; i++) {
				int current = nums[i];
				int streakLength = 1;

				while (FoundInArray(nums, current + 1)) {
					current += 1;
					streakLength += 1;
				}

				longestStreak = Math.Max(longestStreak, streakLength);
			}


			return longestStreak;
		}

		private static bool FoundInArray(int[] nums, int valueToFind) {
			for (int i = 0; i < nums.Length; i++) {
				if (nums[i] == valueToFind) {
					return true;
				}
			}
			return false;
		}


		public static int Solution2(int[] nums) {
			var numSet = new HashSet<int>(nums);
			int longestStreak = 0;

			for (int i = 0; i < nums.Length; i++) {
				int current = nums[i];
				int streakLength = 1;

				while (numSet.Contains(current + 1)) {
					current += 1;
					streakLength += 1;
				}

				longestStreak = Math.Max(longestStreak, streakLength);
			}


			return longestStreak;
		}


		public static int Solution3(int[] nums) {
			int longestStreak = 0;

			Dictionary<int, int> numSet = new Dictionary<int, int>();
			

			for (int i = 0; i < nums.Length; i++) {
				int first = nums[i];
				int last = nums[i];
				int chain = 1;

				if (numSet.ContainsKey(nums[i])) {
					continue;
				}

				if (numSet.ContainsKey(nums[i] - 1)) {
					chain += numSet[nums[i] - 1];
					first = nums[i] - chain + 1;
				}

				if (numSet.ContainsKey(nums[i] + 1)) {
					chain += numSet[nums[i] + 1];
					last = first + chain - 1;
				}

				numSet[nums[i]] = 1;
				numSet[first] = chain;
				numSet[last] = chain;

				longestStreak = Math.Max(longestStreak, chain);
			}


			return longestStreak;
		}
	}
}
