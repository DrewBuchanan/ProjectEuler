using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
	public class Problem3
	{
		public static int Solution ()
		{
			long number = 600851475143;
			double sqrt = Math.Sqrt (number);
			List<int> factors = new List<int> ();
			for (int i = 1; i < sqrt; i++)
				if (number % i == 0)
					factors.Add (i);
			for (int i = factors.Count - 1; i >= 0; i--)
			{
				if (IsPrime (factors [i]))
					return factors [i];
			}
			return factors.Max ();
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
