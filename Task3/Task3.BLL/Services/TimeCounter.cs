using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BLL.Services
{
	public class TimeCounter
	{
		public static int Counter(Func<int, int, int> method, int a, int b, out long ticks)
		{
			var sWatch = Stopwatch.StartNew();
			var result = method(a, b);

			sWatch.Stop();
			ticks = sWatch.ElapsedTicks;

			return result;
		}

		public static int Counter(Func<int, int, int, int, int> method, int a, int b, int c, int d, out long ticks)
		{
			var sWatch = Stopwatch.StartNew();
			var result = method(a, b, c, d);

			sWatch.Stop();
			ticks = sWatch.ElapsedTicks;

			return result;
		}

		public static int Counter(Func<int[], int> method, int[] arguments, out long ticks)
		{
			var sWatch = Stopwatch.StartNew();
			var result = method(arguments);

			sWatch.Stop();
			ticks = sWatch.ElapsedTicks;

			return result;
		}
	}
}
