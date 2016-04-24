using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCommand {
	class MainApp {
		static void Main() {
			//Create user and let her computer
			User user = new User();

			//user presses calculator buttons
			user.Compute('+', 100);
			user.Compute('-', 50);
			user.Compute('*', 10);
			user.Compute('/', 2);
			
			//Undo four commands
			user.Undo(4);

			//redo 3 commands
			user.Redo(3);
			
			//Wait for user
			Console.ReadKey();
		}
	}
}
