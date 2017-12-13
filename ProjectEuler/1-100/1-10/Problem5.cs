using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
	public class Problem5
	{
		public static int Solution ()
		{
			int number = 2519;
			while (true)
			{
				number++;
				for (int i = 2; i <= 20; i++)
				{
					if (number % i != 0)
					{
						goto End;
					}
				}
				return number;
				End:;
			}
			return -1;
		}
	}
}
