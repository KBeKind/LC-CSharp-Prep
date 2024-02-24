//Exercises: Control Flow & Collections

//TODO: Write your code for String Practice below:

Console.WriteLine("Hello, Strings!");



string aString = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

string[] aStringArray = aString.Split(' ');

Console.WriteLine(string.Join("**", aStringArray));

string[] aStringArray2 = aString.Split('.');

Console.WriteLine(string.Join("**", aStringArray2));