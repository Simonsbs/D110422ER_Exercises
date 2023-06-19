using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises {
	public class EX2 {
		public static bool CheckBrackets(string value) {
			while (value.Contains("()") || 
				value.Contains("{}") || 
				value.Contains("[]")|| 
				value.Contains("<>")) {

				value = value.Replace("()", "");
				value = value.Replace("{}", "");
				value = value.Replace("[]", "");
				value = value.Replace("<>", "");
			}

			return value.Length == 0;
		}
	}
}
