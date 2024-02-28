using Technology;

namespace TechnologyTests
{
	[TestClass]
	public class TechnologyTests
	{

		[TestInitialize]
		public void TestSetup()
		{
			AbstractEntity.ResetNextIdForTest();
		}


		[TestMethod]
		public void ComputerSetsProperId()
		{
			Computer testComputer1 = new Computer(2000, "Lenovo", 10);
			Computer testComputer2 = new Computer(2000, "Lenovo", 10);

			Assert.IsTrue(testComputer1.Id == 1);
			Assert.IsTrue(testComputer2.Id == 2);

		}


		[TestMethod]
		public void ComputerSetsAvailableSpace()
		{
			Computer testComputer = new Computer(2000, "Lenovo", 10);

			Assert.AreEqual(1000, testComputer.AvailableSpace, 0.001);
		}

		[TestMethod]
		public void ComputerUseStorage()
		{
			Computer testComputer = new Computer(2000, "Lenovo", 10);

			testComputer.UseStorage(500);

			Assert.AreEqual(500, testComputer.AvailableSpace, 0.001);
		}

		[TestMethod]
		public void ComputerSetsBrand()
		{
			Computer testComputer = new Computer(2000, "Lenovo", 10);

			Assert.IsTrue("Lenovo" == testComputer.Brand);
		}



		[TestMethod]
		public void LaptopStartsAtMaxBattery()
		{
			Laptop testLaptop = new Laptop(2000, "Lenovo", 10);

			Assert.AreEqual(100, testLaptop.BatteryLifePercent, 0.001);
		}

		[TestMethod]
		public void LaptopUsesBattery()
		{

			Laptop testLaptop = new Laptop(2000, "Lenovo", 10);

			testLaptop.UseBattery(10);

			Assert.AreEqual(90, testLaptop.BatteryLifePercent, 0.001);
		}

		[TestMethod]
		public void LaptopSetsWeightViaComputerConstructor()
		{
			Laptop testLaptop = new Laptop(2000, "Lenovo", 10);

			Assert.AreEqual(10, testLaptop.Weight, 0.001);
		}





	}
}