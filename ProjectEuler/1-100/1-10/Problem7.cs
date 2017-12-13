using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
	public class Problem7
	{
		public static int Solution ()
		{
			int number = 0;
			int counter = 0;
			while (counter < 10001)
			{
				number++;
				if (IsPrime (number))
					counter++;
			}
			return number;
		}

		private static bool IsPrime (int v)
		{
			if (v == 1) return false;
			if (v == 2) return true;
			if (v % 2 == 0) return false;

			for (int i = 2; i < v; i++)
				if (v % i == 0) return false;
			return true;
		}
	}
}
