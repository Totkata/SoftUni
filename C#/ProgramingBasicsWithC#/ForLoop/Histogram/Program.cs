using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());
			double UpTo199 = 0;
			double UpTo300 = 0;
			double UpTo599 = 0;
			double UpTo799 = 0;
			double UpTo800 = 0;

			for (int i = 0; i < n; i++)
			{
				int number = int.Parse(Console.ReadLine());

				if (number >= 1 && number < 200)
				{
					UpTo199++;
				}
				else if (number >= 200 && number < 400)
				{
					UpTo300++;
				}
				else if (number >= 400 && number < 600)
				{
					UpTo599++;
				}
				else if (number >= 600 && number < 800)
				{
					UpTo799++;
				}
				else
				{
					UpTo800++;
				}
			}

			Console.WriteLine("{0:f2}%", (UpTo199 / n) * 100);
			Console.WriteLine("{0:f2}%", (UpTo300 / n) * 100);
			Console.WriteLine("{0:f2}%", (UpTo599 / n) * 100);
			Console.WriteLine("{0:f2}%", (UpTo799 / n) * 100);
			Console.WriteLine("{0:f2}%", (UpTo800 / n) * 100);
		}
    }
}
