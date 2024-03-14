using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinningDiscsDebugging
{
	public class CD : BaseDisc, IOpticalDisc
	{
		public CD(string name, int maxCapacity, string disktype, int someUsedCapacity) : base(name, maxCapacity, disktype, someUsedCapacity)
		{
		}

		public void ReadData()
		{
			Console.WriteLine("Would you like to play a game?");
		}

		public void SpinDisc()
		{
			Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.");
		}
	}
}
