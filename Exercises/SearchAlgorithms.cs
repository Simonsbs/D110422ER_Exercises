namespace Exercises {

	public static class SortAlgorithms {
		public static void MergeSort(int[] arr, int left, int right) {
			if (left < right) {
				// middle point
				int mid = left + (right - left) / 2;

				// recursive sort first and second halves
				MergeSort(arr, left, mid);
				MergeSort(arr, mid + 1, right);

				// merge the sorted halves
				Merge(arr, left, mid, right);
			}
		}

		public static void Merge(int[] arr, int left, int mid, int right) {
			int leftSize = mid - left + 1;
			int rightSize = right - mid;

			// temporary arrays
			int[] leftArray = new int[leftSize];
			int[] rightArray = new int[rightSize];

			// copy data to temp arrays
			for (int i = 0; i < leftSize; i++)
				leftArray[i] = arr[left + i];
			for (int j = 0; j < rightSize; j++)
				rightArray[j] = arr[mid + 1 + j];

			// initial indexes for subarrays and merged subarray
			int leftIndex = 0, rightIndex = 0, mergedIndex = left;

			// merge temp arrays
			while (leftIndex < leftSize && rightIndex < rightSize) {
				if (leftArray[leftIndex] <= rightArray[rightIndex]) {
					arr[mergedIndex] = leftArray[leftIndex];
					leftIndex++;
				} else {
					arr[mergedIndex] = rightArray[rightIndex];
					rightIndex++;
				}
				mergedIndex++;
			}

			// copy remaining elements of leftArray[] if any
			while (leftIndex < leftSize) {
				arr[mergedIndex] = leftArray[leftIndex];
				leftIndex++;
				mergedIndex++;
			}

			// copy remaining elements of rightArray[] if any
			while (rightIndex < rightSize) {
				arr[mergedIndex] = rightArray[rightIndex];
				rightIndex++;
				mergedIndex++;
			}
		}

	}


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
