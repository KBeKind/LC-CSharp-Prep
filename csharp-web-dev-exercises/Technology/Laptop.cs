using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
	public class Laptop : Computer
	{

		public int BatteryLifePercent { get; set; } 

		public const int MaxBatteryLife = 100;
		public Laptop(int storageSpaceParam, string brand, int weight) : base(storageSpaceParam, brand, weight)
		{
			BatteryLifePercent = MaxBatteryLife;
		} 
		
		


		public void UseBattery(int usedPercent)
		{


			BatteryLifePercent -= usedPercent;

			if(BatteryLifePercent < 0)
			{
				BatteryLifePercent = 0;
			}
		
		}
		



	}

}
