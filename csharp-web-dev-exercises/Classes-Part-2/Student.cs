using System;
namespace Classes_Part_2
{
	public class Student
	{
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
			// Update the appropriate properties: NumberOfCredits, Gpa

			double currentTotalQualityScore = Gpa * NumberOfCredits;

            double newQualityScore = currentTotalQualityScore + (courseCredits * grade);

			NumberOfCredits += courseCredits;

            Gpa = newQualityScore / NumberOfCredits;

		}

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits

            if(credits <= 29)
            {
                return "Freshman";
            }
            else if(credits <= 59)
            {
                return "Sophomore";
            }
            else if(credits <= 89)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }

            return "grade level tbd";
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.

        
        public override string ToString()
        {
            return $"Student Name: {Name}, Student ID: {StudentId},\n Number of Credits: {NumberOfCredits}, GPA: {Gpa} \nGrade Level: {GetGradeLevel(NumberOfCredits)}";
        }

		public override bool Equals(object? obj)
		{
            if(obj == this)
            {
                return true;
            }
            if(obj == null)
            {
                return false;
            }

            if(obj.GetType() != typeof(Student))
            {
                return false;
            }
     
            Student studentObj = obj as Student;
            return StudentId == studentObj.StudentId;
		
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(StudentId);
		}



		// TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
		//  Student objects equal.




	}
}

