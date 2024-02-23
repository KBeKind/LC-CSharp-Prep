
//Console.WriteLine("What you name?");

//string name = Console.ReadLine();

//Console.WriteLine($"Hello {name}!");


//Console.WriteLine("What length of rectangle?");
//string recLength = Console.ReadLine();
//int length= CheckInput(recLength, "length");


//Console.WriteLine("What width of rectangle?");
//string recWidth = Console.ReadLine();
//int width = CheckInput(recWidth, "width");

//int rectArea = length * width;

//Console.WriteLine($"Rectangle area: {length} x {width} = {rectArea}"); 

//int CheckInput (string input, string side){
//	int testVal;
//	while (!int.TryParse(input, out testVal) || testVal <= 0)
//	{
//		Console.WriteLine("sorry not valid input");
//		Console.WriteLine($"What {side} of rectangle?");
//		input = Console.ReadLine();
//	}
//	return int.Parse(input);

//}




//string aString = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

//string lowerCaseAString = aString.ToLower();

//Console.WriteLine("Enert a a word to search for");
//string searchWord = Console.ReadLine();

//bool found = false;

//if(lowerCaseAString.Contains(searchWord))
//{
//	found = true;
//}

//Console.WriteLine($"boolean for word found: {found}");

//if (found)
//{
//	int indexOfSearchWord = lowerCaseAString.IndexOf(searchWord);
//	int lengthOfSearchWord = searchWord.Length;


//	Console.WriteLine($"Index of word:{indexOfSearchWord}, Lenght of word: {lengthOfSearchWord}");

//	Console.WriteLine($"{aString.Substring(0, indexOfSearchWord)} REMOVED STUFF {aString.Substring(indexOfSearchWord + lengthOfSearchWord)}");

//}



//Console.WriteLine("How many miles u drive?");
//int miles = int.Parse(Console.ReadLine());

//Console.WriteLine("How many gallons of gas u use?");
//int gallons = int.Parse(Console.ReadLine());

//double mpg = miles / gallons;

//Console.WriteLine($"Here how many miles per gallon u get: {mpg}");



using Chap2Exer1;

Console.WriteLine("Give me radius of a circle");

string input = Console.ReadLine();

double r = CheckRadiusInput(input);




Circle aCircle = new Circle(r);

Console.WriteLine($"The area of a circle with radius {aCircle.Radius} is {aCircle.Area}");

Console.WriteLine($"The circumference of a circle with radius {aCircle.Radius} is {aCircle.Circumference}");

Console.WriteLine("The diameter of the circle is " + aCircle.Diameter);

Console.WriteLine("what your mpg of car?");

int mpg = int.Parse(Console.ReadLine());

double gallonsNeeded = aCircle.Circumference / mpg;


Console.WriteLine($"You can drive around the circle with this many gallons: {gallonsNeeded} ");


double CheckRadiusInput(string input)
{
	while(!double.TryParse(input, out double aValue) || aValue <= 0)
	{
        Console.WriteLine("Bad entry need a good entry");
		Console.WriteLine("Give me radius of a circle");
		input = Console.ReadLine();
    }
	return double.Parse(input);
}