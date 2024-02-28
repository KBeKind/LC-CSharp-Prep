using Cats;

namespace CatTests
{
	[TestClass]
	public class CatTests
	{
		[TestMethod]
		public void InheritsBaseInFirstConstructor()
		{

			HouseCat keyboardCat = new HouseCat("Keyboard Cat", 7);
			Assert.AreEqual(7, keyboardCat.Weight, 0.001);

		}
	}
}