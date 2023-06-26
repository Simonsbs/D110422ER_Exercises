namespace Exercises {
	public static class EX4 {
		public static int GetMaxProfit(int[] value) {
			int maxProfit = 0;
			for (int i = 0; i < value.Length - 1; i++) {
				for (int j = i + 1; j < value.Length; j++) {
					int tempProfit = value[j] - value[i];
					if (tempProfit > maxProfit) { 
						maxProfit = tempProfit;
					}
				}
			}

			return maxProfit;
		}
	}
}
