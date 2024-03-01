using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudioChap8SpinningDiscs
{
	public class DVD : BaseDisc, IOpticalDisc
	{
		// TODO: Implement your custom interface.

		// TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
		//  need to be declared separately.


		public int DataStorageSize => 6000;
		public int SpinSpeed => 200;

		public DVD(string title) : base(title) { }

		public void SpinDisc()
		{
			Console.WriteLine($"DVD Spinning at {SpinSpeed} RPM");
            Console.WriteLine($"{DiscTitle}");
            Console.WriteLine($"Total storage: {DataStorageSize} MB, Used Storage: {StorageUsed} MB");

		}

		public override void AddDataItem(string key, int value)
		{
			if(DataStorageSize - StorageUsed - value > 0)
			{
				DataItems.Add(key, value);
				StorageUsed += value;

                Console.WriteLine($"Data: {key} added.  Remaining storage: {DataStorageSize - StorageUsed} MB");

            } else
			{
                Console.WriteLine("Sorry there isnt enough disc space left");
            }
		}
	}
}
