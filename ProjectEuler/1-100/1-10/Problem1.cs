using System.Collections.Generic;

namespace ProjectEuler
{
	public class Problem1
	{
		public static List<int> FindMultiplesOfXOrYBelowZ (int x, int y, int z)
		{
			List<int> mults = new List<int> ();
			for (int i = 1; i < z; i++)
				if (i % x == 0 || i % y == 0)
					mults.Add (i);
			return mults;
		}

		public static int TestCase ()
		{
			List<int> mults = FindMultiplesOfXOrYBelowZ (3, 5, 10);
			int sum = 0;
			for (int i = 0; i < mults.Count; i++)
				sum += mults [i];
			return sum;
		}

		public static int Solution ()
		{
			List<int> mults = FindMultiplesOfXOrYBelowZ (3, 5, 1000);
			int sum = 0;
			for (int i = 0; i < mults.Count; i++)
				sum += mults [i];
			return sum;
		}
	}
}
