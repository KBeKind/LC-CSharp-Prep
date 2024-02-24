//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

Console.WriteLine("Hello, Lists!");



static int sumOfList(List<int> list)
{
    int sum = 0;
    foreach (int num in list)
    {
        sum += num;
    }
    return sum;
}


List<int> aList = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

Console.WriteLine(sumOfList(aList));



string aString = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

string[] aStringArray = aString.Split(' ');

List<string> stringList = new List<string>(aStringArray);

static void printStringList(List<string> list)
{
    Console.WriteLine("Enter a word length");
    string input =Console.ReadLine();

    int intInput = int.Parse(input);

    foreach (string str in list)
    {
        if(str.Length == intInput)
        {
			Console.WriteLine(str);
		}
	}
}


printStringList(stringList);



