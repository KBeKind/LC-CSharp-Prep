// --------- Divide By Zero! ----------


static double Divide(double x, double y)
{
	// Write your code here!
	double result = 0;

	if (y == 0.0)
	{
		throw new ArgumentOutOfRangeException("You cannot divide by zero");

	}
	else
	{
		return x / y;
	}


}


// Test out your Divide() function here!


// --------- Test Student Labs ----------

var aResult = Divide(20, 5);
Console.WriteLine(aResult);

//var aResult2 = Divide(20, 0);
//Console.WriteLine(aResult2);


static int CheckFileExtension(string fileName)
{
	string fileEnding;
	try
	{
		fileEnding = fileName.Split('.')[1];


		if (fileEnding.Equals("cs"))
		{
			return 1;
		}
		else
		{
			return 0;
		}

	}
	catch (IndexOutOfRangeException e)
	{
		Console.WriteLine($"there is no '.' {e}");
		try
		{
			throw new ArgumentNullException("fileName", "Student did not submit any work!");
		}
		catch (ArgumentNullException)
		{
			Console.WriteLine("Student did not submit any work!");
			return 0;
		}
	}

}



// Test out your CheckFileExtension() function here!

Dictionary<string, string> students = new Dictionary<string, string>();
students.Add("Carl", "Program.cs");
students.Add("Brad", "");
students.Add("Elizabeth", "MyCode.cs");


Console.WriteLine(CheckFileExtension(students["Carl"]));
Console.WriteLine(CheckFileExtension(students["Brad"]));
Console.WriteLine(CheckFileExtension(students["Elizabeth"]));