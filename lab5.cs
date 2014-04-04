using System;

namespace casenum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Sausage\tBun\tKetchup\tMustard\tOnions");

			for (int sau=0; sau<2; sau++) {

				for (int bun=0; bun<2; bun++) {

					for (int ket=0; ket<2; ket++) {

						for (int mus=0; mus<2; mus++) {
			
							for (int oni=0; oni<2; oni++) {
								Console.WriteLine ("{0}\t{1}\t{2}\t{3}\t{4}\t",sau,bun,ket,mus,oni);
							}
						}
					}
				}
			}
		}
	}
}
