namespace CarTests;

using Car;

[TestClass]
public class CarTests
{
    Car test;

    [TestInitialize]
    public void CreateCarObject()
    {
		test = new Car("Brand", "Model", 10, 50);
	}


    //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
    [TestMethod]
    public void EmptyTest()
    {
        Assert.AreEqual(10, 10, .001);
    }


    //TODO: constructor sets gasTankLevel properly
    [TestMethod]
    public void TestInitialGasTank()
    {
        Assert.AreEqual(10, test.GasTankLevel, .001);
    }


    //TODO: gasTankLevel is accurate after driving within tank range






    //TODO: gasTankLevel is accurate after attempting to drive past tank range
    //TODO: can't have more gas than tank size, expect an exception
}
