using System;
namespace Classes_Part_2
{
	public class Course
	{
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }


		// TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
		//  just the class fields.

		public override string ToString()
		{
			return $"Course Topic: {Topic}, Instructor: {Instructor}, Number of Students: {enrolledStudents.Count}";
		}



		// TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
		//  Course objects equal.

		public override bool Equals(object? obj)
		{
			if(this == obj) return true ;
			if (obj == null) return false;
			if (obj.GetType() != GetType()) ;
			Course aCourse = obj as Course ;
			return aCourse.Topic == Topic && aCourse.Instructor == Instructor; 
	
		}



	}
}

