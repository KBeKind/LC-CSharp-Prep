using System;

namespace Classes;

public class Student
{
    private static int nextId = 1;
    public string Name { get; set; }
    public int StudentId {get; set;}
    public int NumberOfCredits { get; set; }
	public double Gpa { get; set; }


    public Student(string name, int numberOfCredits, double gpa)
    {
        Name = name;
        StudentId = nextId;
        NumberOfCredits = numberOfCredits;
        Gpa = gpa;
        nextId++;
    }

    public Student(string name) : this(name, 0, 0) { }


}
