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
				Console.WriteLine($"Nod = {Euclid.Nod(48, 64)}");

				Console.WriteLine($"Nod of four numbers = {Euclid.Nod(78, 294, 570, 36)}");

				Console.WriteLine($"Binary Nod = {Euclid.BinaryNod(48, 64)}");

				Console.WriteLine($"Nod with array params = {Euclid.NodWithArrParams(78, 294, 570, 36)}");
			}
			catch (Exception e)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.WriteLine(e.Message);
				throw;
			}

			Console.ReadKey();
		}
	}
}
