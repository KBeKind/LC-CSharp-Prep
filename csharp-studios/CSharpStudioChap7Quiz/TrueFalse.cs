using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudioChap7Quiz
{
	public class TrueFalse : Question
	{
		const string TypeDirections = "True or False";
		public TrueFalse(string text, List<int> answer) : base(text, answer, TypeDirections){}

		public override bool GradeQuestion()
		{ 
			if (UserAnswer[0] == CorrectAnswer[0])
			{
				return true;
			}
			return false;

		}
	}
}
