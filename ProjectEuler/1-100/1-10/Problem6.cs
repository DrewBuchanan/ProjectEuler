using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
	public class Problem6
	{
		public static long Solution ()
		{
			long sum = 0;
			long sumOfSquares = 0;
			for (int i = 1; i <= 100; i++)
			{
				sum += i;
				sumOfSquares += i * i;
			}
			return (sum * sum) - sumOfSquares;
		}
	}
}
