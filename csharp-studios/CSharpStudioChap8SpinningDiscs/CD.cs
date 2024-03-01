using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudioChap8SpinningDiscs
{
	public class CD : BaseDisc, IOpticalDisc
	{
		// TODO: Implement your custom interface.

		// TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
		//  need to be declared separately. 

		public int DataStorageSize => 700;

		public int SpinSpeed => 100;

		public CD(string title) : base(title) { }

		public void SpinDisc()
		{
            Console.WriteLine($"CD Spinning at {SpinSpeed} RPM");
			Console.WriteLine($"Total storage: {DataStorageSize} MB, Used Storage: {StorageUsed} MB");
        }

		public override void AddDataItem(string key, int value)
		{
			if (DataStorageSize - StorageUsed - value > 0)
			{
				DataItems.Add(key, value);
				StorageUsed += value;

				Console.WriteLine($"Data: {key} added.  Remaining storage: {DataStorageSize - StorageUsed} MB");

			}
			else
			{
				Console.WriteLine("Sorry there isnt enough disc space left");
			}
		}
	}
}
