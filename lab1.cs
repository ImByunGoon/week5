using System;

namespace halftree
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int Loop=1; Loop<=5; Loop++) {
				for (int Loop2=1; Loop2<=Loop; Loop2++) {
					Console.Write ("*");
				}
				Console.WriteLine ("");
			}
		}
	}
}
