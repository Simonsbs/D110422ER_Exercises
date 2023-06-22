using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises {
	internal class BigONotationSamples {
		public BigONotationSamples() {
			var arr = new int[10]{
				1,2,3, 4,5,6,7,8,9,10
			};

			Sample1(arr);
		}

























		public void Sample1(int[] arr) {
			// O(n)
			for (int i = 0; i < arr.Length; i++) {
				Console.WriteLine(i);


				if (i < arr.Length - 3) {
					return;
				}
			}
		}


		public void Sample2(int[,] arr) {
			// O(n^2)
			for (int i = 0; i < arr.Length; i++) {
				Console.WriteLine(i);
				if (i > 5) {
					continue;
				}
				for (int j = 0; j < arr.Length; j++) {
                    Console.WriteLine(i);
                }
			}
		}



		public bool AreUnique(int[] array) {
			for (int i = 0; i < array.Length; i++) {
				for (int j = i + 1; j < array.Length; j++) {
					//if (i == j) { continue; }
					if (array[i] == array[j]) {
						return false;
					}
				}
			}

			return true;
		}


		public bool AreUnique2(int[] array) {
			HashSet<int> set = new HashSet<int>();

			return true;
		}
	}
}
