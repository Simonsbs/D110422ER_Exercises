using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises {
	public class Program {
		static void Main(string[] args) {
			BigONotationSamples bo = new BigONotationSamples();

			bo.AreUnique2(new int[] { 1, 2, 3, 4, 5, 6, 7 });
			bo.AreUnique2(new int[] { 1, 2, 1, 4, 5, 6, 7 });

			bo.AreUniqe4(new int[] { 999, 1, 2, 3, 4 });
		}


	}
}
