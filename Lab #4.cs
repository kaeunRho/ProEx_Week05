using System;

namespace _4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		 for(;;){
				Console.Write ("Enter the operation[+,-,*,/], if you want to quit enter 'q':");
				string operation = Console.ReadLine ();
				if (operation == "q") {
					Console.WriteLine ("Bye!");
					break;
				}
				switch(operation){
				case "+":
					Console.Write ("Enter the first number:");
					int firstnum = int.Parse (Console.ReadLine ());
					Console.Write ("Enter the second number:");
					int secondnum = int.Parse (Console.ReadLine ());
					Console.WriteLine ("Result:{0}", firstnum + secondnum);
					break;
				case "-":
					Console.Write ("Enter the first number:");
					int a = int.Parse (Console.ReadLine ());
					Console.Write ("Enter the second number:");
					int b = int.Parse (Console.ReadLine ());
					Console.WriteLine ("Result:{0}", a - b);
					break;
				case "*":
					Console.Write ("Enter the first number:");
					int c = int.Parse (Console.ReadLine ());
					Console.Write ("Enter the second number:");
					int d = int.Parse (Console.ReadLine ());
					Console.WriteLine ("Result:{0}", c * d);
					break;
				case "/":
					Console.Write ("Enter the first number:");
					int e = int.Parse (Console.ReadLine ());
					Console.Write ("Enter the second number:");
					int f = int.Parse (Console.ReadLine ());
					Console.WriteLine ("Result:{0}", e / f);
					break;
				default:
						Console.WriteLine ("You entered wrong operation, Only +,-,*,/,q are allowed");
						break;
				
					}
				}
	
		}
	}
	}
