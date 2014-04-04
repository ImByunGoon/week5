using System;

namespace calculater
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			while (true) {
				Console.Write ("Enter the operater[+,-,/,* or input [q] to quit]:");
				string oper = Console.ReadLine ();
				while (true) {//check operator
				    
					if (oper == "+") {
						break;
					} else if (oper == "-") {
						break;	
					} else if (oper == "/") {
						break;
					} else if (oper == "*") {
						break;
					} else if (oper == "q") {
						break;
					} else {
						Console.WriteLine ("wrong input: {0}", oper);
						Console.Write ("Enter the operater[+,-,/,* or input [q] to quit]:");
						oper = Console.ReadLine ();

					}

				}

				if (oper == "q") {
					break;
				
				}

				Console.Write ("Enter the first number:");
				int num1 = int.Parse (Console.ReadLine ());
				Console.Write ("Enter the second number:");
				int num2 = int.Parse (Console.ReadLine ());

				if (oper == "+") {
					Console.WriteLine ("result:{0}", num1 + num2);
				} else if (oper == "-") {
					Console.WriteLine ("result:{0}", num1 - num2);
				} else if (oper == "/") {
					Console.WriteLine ("result:{0}", num1 / num2);
				} else if (oper == "*") {
					Console.WriteLine ("result:{0}", num1 * num2);
				} else if (oper == "q") {
					Console.WriteLine ();
					break;
				}
			}
			Console.WriteLine ("Good bye!");
		}
	}
}
