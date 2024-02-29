using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudioChap7Quiz
{
	public class MultiChoice : Question
	{

		const string TypeDirections = "Multiple Choice: Pick the one answer you think is correct.";

		public MultiChoice(string text, List<int> answer) : base(text, answer, TypeDirections) { }
	

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
