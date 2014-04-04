using System;

namespace numtable9
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int count=1; count <= 9; count++) {

				Console.WriteLine ("[{0} times table]",count);

					for (int count2=1; count2<=9; count2++) {
						Console.WriteLine ("{0} * {1} ={2}", count, count2, count * count2);
					}
				Console.WriteLine ("");
			
			}
		}
	}
}
