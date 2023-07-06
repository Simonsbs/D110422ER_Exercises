using System;
using System.Linq;

namespace Exercises {
	public static class MinimumCostArray {

		// [2,4,6,8,10], [1,1,1,1,1]

		public static long Solution1(int[] nums, int[] costs) {
			long result = long.MaxValue;

			for (int target = 0; target < nums.Length; target++) {
				long currentCost = 0;

				for (int i = 0; i < nums.Length; i++) {
					currentCost += Math.Abs(nums[i] - nums[target]) * costs[i];
				}

				if (currentCost < result) {
					result = currentCost;
				}
			}

			return result;
		}

		public static long Solution2(int[] nums, int[] costs) {
			int min = nums.Min();
			int max = nums.Max();

			while (min < max) {
				int mid = min + (max - min) / 2;

				long costLeft = GetCost(nums, costs, mid);
				long costRight = GetCost(nums, costs, mid + 1);

				if (costLeft < costRight) {
					max = mid;
				} else {
					min = mid + 1;
				}
			}

			return GetCost(nums, costs, min);
		}

		private static long GetCost(int[] nums, int[] costs, int target) {
			long result = 0;

			for (int i = 0; i < nums.Length; i++) {
				result += Math.Abs(nums[i] - target) * costs[i];
			}

			return result;
		}
	}
}
