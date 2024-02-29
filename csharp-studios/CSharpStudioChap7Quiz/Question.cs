using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudioChap7Quiz
{
	public abstract class Question
	{
		public string QuestionText { get; set; }

		public List<string> PossibleAnswers { get; set; }

		public List<int> CorrectAnswer { get; set; }

		public List<int> UserAnswer { get; set; } = new List<int>();

		public string Directions { get; set; }

		public Question(string questionText, List<int> correctAnswer, string directions) {
			QuestionText = questionText;
			CorrectAnswer = correctAnswer;
			Directions = directions;
			
		}

		public abstract bool GradeQuestion();

	}
}
