using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamShop
{
	internal class ConeComparer : IComparer<Cone>
	{
		public int Compare(Cone x, Cone y)
		{
			double diff = x.Cost - y.Cost;

			if (diff > 0)
			{
				return 1;
			}
			else if (diff < 0)
			{
				return -1;
			}
			else
			{
				return 0;
			}

		}
	}
}
