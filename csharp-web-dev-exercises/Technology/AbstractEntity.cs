using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
	public class AbstractEntity
	{



		private static int NextId { get; set; } = 1;

		private readonly int id;

		public int Id => id;

		public AbstractEntity() {

			id = NextId;
			NextId++;
		}


#if DEBUG
		public static void ResetNextIdForTest()
		{
			NextId = 1;
		}
#endif

	}
}
