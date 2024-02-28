using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
	public class Computer : AbstractEntity
	{

		private readonly int storageSpace;

		public int StorageSpace  => storageSpace;

		public int AvailableSpace { get; set; }
		public string Brand { get; set; }
		public int Weight { get; set; }

		public static bool HasRam { get; } = true;

		public Computer(int storageSpaceParam, string brand, int weight) : base()
		{
			storageSpace = storageSpaceParam;
			Brand = brand;
			Weight = weight;
			AvailableSpace = storageSpace - 1000;
		}

		
		public void UseStorage(int amount)
		{
			if (AvailableSpace >= amount)
			{
				AvailableSpace -= amount;
			}
		}

		
		public void PrintWelcomeMessage()
		{
			Console.WriteLine($"Welcome to the {Brand} computer!  Your available storage is {AvailableSpace} GB of {StorageSpace} GB total.");
		}


	}
}
