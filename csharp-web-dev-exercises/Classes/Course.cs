using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class Course
	{
		public string CourseTitle { get; set; }
		public Teacher Teacher { get; set; }
		public List<Student> StudentsList { get; set; } = new List<Student>();

	}
}
