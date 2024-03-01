using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudioChap8SpinningDiscs
{
	public abstract class BaseDisc
	{

		public int StorageUsed { get; set; } = 0;

		public string DiscTitle { get; set; }

		public Dictionary<string, int> DataItems { get; set; } = new Dictionary<string, int>();

		public BaseDisc(string title)
		{
			DiscTitle = title;
		}

		public abstract void AddDataItem(string key, int value);

	}
}
