using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
	public class Problem4
	{
		public static int Solution ()
		{
			int largest = 0;
			for (int i = 999; i > 99; i--)
				for (int j = 999; j > 99; j--)
				{
					int res = i * j;
					if (IsPalindrome (res.ToString ()))
						if (res > largest)
							largest = res;
				}
			return largest;
		}

		static bool IsPalindrome (string s)
		{
			int i = 0;
			while (i < s.Length / 2)
			{
				if (s [i] != s [s.Length - 1 - i])
					return false;
				i++;
			}
			return true;
		}
	}
}
