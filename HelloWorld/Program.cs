using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
	class Program
	{
		class Hello
		{
			static void Main()
			{
				//Console.WriteLine("Hello World!");

				//// Keep the console window open in debug mode.
				//Console.WriteLine("Press any key to exit.");
				//Console.ReadKey();
				Console.WriteLine("What would you like me to say?");
				string _userInput = Console.ReadLine();
				Console.WriteLine("You asked me to say: " + _userInput);

				Console.WriteLine("Press any key to exit.");
				Console.ReadKey();
			}
		}
	}
}