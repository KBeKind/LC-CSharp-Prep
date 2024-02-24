//Exercises: Control Flow & Collections

//TODO: Write your code for Dictionary Practice below:

Console.WriteLine("Hello, Dictionary!");

Dictionary<string, int> studentDictionary = new Dictionary<string, int>();

string input = "";

do {
    Console.WriteLine("Enter a student name:");
    input = Console.ReadLine();

	if (input is not null && input.Trim() != "")
	{

		Console.WriteLine("Enter a student id:");
		string input2 = Console.ReadLine();

		while (!int.TryParse(input2, out int id) || id <= 0)
		{
			Console.WriteLine("Invalid input. Please enter a valid id.");
			input2 = Console.ReadLine();
		}

		int intInput2 = int.Parse(input2);

	
			studentDictionary.Add(input, intInput2);
	}

}
while (input.Trim() != "" && input is not null);




foreach (KeyValuePair<string, int> entry in studentDictionary)
{
    Console.WriteLine($"Student Name: {entry.Key}  Student ID: {entry.Value}");
}