using System;

namespace guessgame
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Random random = new Random ();
			int answer = random.Next (0, 100);

			Console.WriteLine (" Let's guess number! I will chose 1 to 99 , you have 6 chances!"); 

			int guess = 0;
			for (int chance=1; chance<=6; chance++) {
				Console.Write("guess:");
				guess = int.Parse (Console.ReadLine ());

				if (guess > answer) {
					Console.WriteLine ("Too high~");
				} else if (guess < answer) {
					Console.WriteLine ("Too low~");
				} else if (guess == answer) {
					Console.WriteLine ("You've got correct answer!");
					break;
				} else {
					Console.WriteLine ("You can use only numbers");
				}

				}

			}



		}
	}

