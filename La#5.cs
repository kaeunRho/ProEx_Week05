using System;

namespace _5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("=================1bit===============");
			for (int i = 0; i < 2; i++) {
				Console.WriteLine("{0}",i);
			}

			Console.WriteLine ("=================2bits==============");
			for (int i = 0; i < 2; i++) {
				for (int j = 0; j < 2; j++){
					Console.WriteLine("{0}\t{1}",i,j);
					}

				}

			Console.WriteLine ("=================3bits==============");
			for ( int i = 0; i < 2; i++) {
				for (int j = 0; j < 2; j++) {
					for (int k = 0; k < 2; k++){
						Console.WriteLine("{0}\t{1}\t{2}",i,j,k);
					}
				
				}
			
			}

			Console.WriteLine ("=================4bits==============");
			for ( int i = 0; i < 2; i++) {
				for (int j = 0; j < 2; j++) {
					for (int k = 0; k < 2; k++){
						for (int l = 0; l < 2; l++) {
							Console.WriteLine("{0}\t{1}\t{2}\t{3}",i,j,k,l);
						}
					}
				}
			}

			Console.WriteLine ("=================5bits==============");
			for ( int i = 0; i < 2; i++) {
				for (int j = 0; j < 2; j++) {
					for (int k = 0; k < 2; k++){
						for (int l = 0; l < 2; l++) {
							for (int m = 0; m < 2; m++) {
								Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",i,j,k,l,m);
							}
						}
					}
				}
			}
			Console.WriteLine ("===================END================");

				
		}
	}
}
