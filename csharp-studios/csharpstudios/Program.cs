// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Dictionary<char, int> charCounts = new Dictionary<char, int>();

string aString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

//Console.WriteLine("Enter a string to count the chars of:");

//string aString2 = Console.ReadLine();

//string aString2LowerCase = aString.ToLower();

string content;
string contentLowerCase;

string filePath = "textfile.txt";
try
{
	content = File.ReadAllText(filePath);
	contentLowerCase = content.ToLower();
	foreach (char c in contentLowerCase)
	{
		if (char.IsLetter(c))
		{
			if (charCounts.ContainsKey(c))
			{
				charCounts[c]++;
			}
			else
			{
				charCounts.Add(c, 1);
			}
		}


	}
}
catch (IOException e)
{
	Console.WriteLine("An error occurred: " + e.Message);
}



foreach(KeyValuePair<char, int> kvp in charCounts)
{
	Console.WriteLine($"{kvp.Key} : {kvp.Value}");
}