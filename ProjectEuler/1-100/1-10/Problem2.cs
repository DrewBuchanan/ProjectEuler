using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
	public class Problem2
	{
		public static List<uint> GetFibonacciNumbersBelowX (uint x)
		{
			List<uint> fibonacci = new List<uint> ();
			fibonacci.Add (1);
			fibonacci.Add (2);
			while (fibonacci [fibonacci.Count - 1] < x)
			{
				fibonacci.Add (fibonacci [fibonacci.Count - 2] + fibonacci [fibonacci.Count - 1]);
			}
			return fibonacci;
		}

		public static uint Solution ()
		{
			List<uint> evens = Problem2.GetFibonacciNumbersBelowX (4000000).Where (x => x % 2 == 0).ToList ();
			uint sum = 0;
			for (int i = 0; i < evens.Count; i++)
				sum += evens [i];
			return sum;
		}
	}
}
