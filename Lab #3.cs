using System;

namespace _3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		    Random random = new Random ();
			int x = random.Next (0, 100);//
			//Console.WriteLine ("{0}",x);
			for (int i = 0; i < 6; i++) {
				Console.Write ("What's Your Guess? ");
				string Guess1 = Console.ReadLine ();
				int Guess = int.Parse (Guess1);
				if (x == Guess) {
					Console.WriteLine ("You got it!!!");
					break;
				}
				if (x < Guess) {
					Console.WriteLine ("Too high!!!");
				}
				if (x > Guess) {
					Console.WriteLine ("Too low!!!");
				}
				if (i ==5 && (x < Guess || x > Guess)) {
					Console.WriteLine ("No more Guess, Better luck next time!");
			}

			}

		}
	}
}
