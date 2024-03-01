using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudioChap8SpinningDiscs
{
	public interface IOpticalDisc
	{

		int SpinSpeed { get; }

		int DataStorageSize { get; }

		void SpinDisc();

	}
}
