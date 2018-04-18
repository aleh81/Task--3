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
			Console.WriteLine($"Nod = {Euclid.Nod(48, 64)}");

		    Console.WriteLine($"Nod of four numbers = {Euclid.NodFour(78, 294, 570, 36)}");
			Console.ReadKey();
		}
	}
}
