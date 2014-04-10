using System;

namespace _01
{
	class MainClass
	{
		public static void Main (string[] args)
		{ 
			for (int outer = 1; outer <= 9; outer++) 
			{ 
				Console.WriteLine ("[{0} times table]", outer);
				for (int inner = 1; inner <=9 ; inner++) {
					Console.WriteLine ("{0}*{1}={2}",outer,inner, outer * inner);

				} 

			}
		
	}
}}
