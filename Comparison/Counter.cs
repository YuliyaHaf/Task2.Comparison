using System;
using System.Diagnostics;

namespace Comparison
{
	class Counter
	{
		static void CounterMethod()
		{
			var stopwatch = Stopwatch.StartNew();
			stopwatch.Start();
			for (int i = 0; i < 10000; i++)
			{
				//SomeAction();
			}

			stopwatch.Stop();

			Console.WriteLine("Time elapsed: {0}", stopwatch.ElapsedMilliseconds);
		}
	}
}
