using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCommand {
	class Calculator {
		private int _current = 0;
		public void Operation(char @operator, int operand) {
			switch (@operator) {
				case '+': _current += operand; break;
				case '-': _current -= operand; break;
				case '*': _current *= operand; break;
				case '/': _current /= operand; break;
			}
			Console.WriteLine("Current value = {0,3} (following {1} {2})",_current,@operator,operand);
		}
	}
}
