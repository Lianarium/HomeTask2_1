using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace HomeTask2_2
{
	class NameComparer : IComparer<string[]>
	{
		public int Compare(string[] o1, string[] o2)
		{
			if (o1[0].Length > o2[0].Length)
			{
				return 1;
			}
			else if (o1[0].Length < o2[0].Length)
			{
				return -1;
			}

			return 0;
		}
	}
}
