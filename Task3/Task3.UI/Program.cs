using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.BLL.Services;
using Task3.BLL.Helpers;

namespace Task3.UI
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write($"Euclid Nod = {Euclid.Nod(48, 64, out var ticks)} ");
				Console.WriteLine($"Elapsed time: {ticks} ticks");

				Console.Write($"Binary Nod = {Euclid.BinaryNod(48, 64, out ticks)} ");
				Console.WriteLine($"Elapsed time: {ticks} ticks");

				Console.Write($"Nod of four numbers = {Euclid.Nod(78, 294, 570, 36, out ticks)} ");
				Console.WriteLine($"Elapsed time: {ticks} ticks");

				Console.Write($"Nod with array params = {Euclid.NodWithArrParams(out ticks,  78, 294, 570, 36)} ");
				Console.WriteLine($"Elapsed time: {ticks} ticks");
			}
			catch (Exception e)
			{
				ExceptionDisplay.Display(e);
			}

			Console.ReadKey();
		}
	}
}
