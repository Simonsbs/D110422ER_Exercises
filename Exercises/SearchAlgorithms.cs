namespace Exercises {
	public static class SearchAlgorithms {
		public static int BinarySearch(int[] arr, int target) {
			int left = 0;
			int right = arr.Length - 1;

			int loopCount = 0;

			while (left <= right) { 
				loopCount++;

				int midPoint = left + right / 2;

				if (arr[midPoint] == target) {
					return midPoint;
				}

				if (arr[midPoint] < target) {
					left = midPoint + 1;
				} else {
					right = midPoint - 1;
				}
			}



			return -1;
		}
	}
}
