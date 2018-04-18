using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.BLL.Services;

namespace Task3.UI
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write($"Nod = {Euclid.Nod(48, 64, out var ticks)} ");
				Console.WriteLine($"Elapsed time: {ticks} ticks");

				Console.Write($"Nod of four numbers = {Euclid.Nod(78, 294, 570, 36, out ticks)} ");
				Console.WriteLine($"Elapsed time: {ticks} ticks");

				Console.Write($"Binary Nod = {Euclid.BinaryNod(48, 64, out ticks)} ");
				Console.WriteLine($"Elapsed time: {ticks} ticks");

				Console.Write($"Nod with array params = {Euclid.NodWithArrParams(out ticks,  78, 294, 570, 36)} ");
				Console.WriteLine($"Elapsed time: {ticks} ticks");
			}
			catch (Exception e)
			{
				Console.Beep();
				Console.BackgroundColor = ConsoleColor.Red;
				Console.WriteLine(e.GetType());
				Console.WriteLine(e.Message);
			}

			Console.ReadKey();
		}
	}
}
