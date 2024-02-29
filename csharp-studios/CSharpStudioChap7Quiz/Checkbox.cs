using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudioChap7Quiz
{
	public class Checkbox : Question
	{

		const string TypeDirections = "CheckBox: Answer as many as you think are correct separated by a space.";


		public Checkbox(string text, List<int> answer) : base(text, answer, TypeDirections) { }

		public override bool GradeQuestion()
		{
            
            if (CorrectAnswer.Count != UserAnswer.Count) { return false; }
            int j = 0;
			for (int i = CorrectAnswer.Count - 1; i >= 0; i--)
			{
				if (CorrectAnswer.Contains(UserAnswer[j]))
				{
					CorrectAnswer.RemoveAt(CorrectAnswer.IndexOf(UserAnswer[j]));
					j++;
                   
                } else
				{
					return false;
				}
			}

			return true;
		}

	}
}
