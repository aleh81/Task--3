using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BLL.Services
{
    public class Euclid
    {
        public static int Nod(int a, int b)
        {
            var remainder = a % b;
            a = b;

            while (true)
            {
                var tmp = remainder;

                if (remainder == 0)
                {
                    break;
                }

                remainder = a % remainder; 
                a = tmp;
            }

            return a;
        }

        public static int Nod(int a, int b, int c, int d)
        {
            var nodAB = Nod(a, b);
            var nodBC = Nod(nodAB, c);
            var nodCD = Nod(nodBC, d);

            return nodCD;
        }

	    public static int BinaryNod(int a, int b)
	    {
			var k = 1;

		    while ((a != 0) && (b != 0))
		    {
			    while ((a % 2 == 0) && (b % 2 == 0))
			    {
				    a /= 2;
				    b /= 2;
				    k *= 2;
			    }

			    while (a % 2 == 0)
			    {
				    a /= 2;
			    }

			    while (b % 2 == 0)
			    {
				    b /= 2;
			    }

			    if (a >= b)
			    {
				    a -= b;
			    }
			    else
			    {
				    b -= a;
			    }
		    }

		    return b * k;
		}
    }
}
