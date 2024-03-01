
using CSharpStudioChap7Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBracketsTests
{
	[TestClass]
	public class QuizTests
	{
		[TestMethod]
		public void TFQuestionSetsText()
		{
			TrueFalse test = new TrueFalse("test text", new List<int>{1});

			Assert.IsTrue(test.QuestionText == "test text");
		}

		[TestMethod]
		public void TFQuestionSetsAnswers() {

			List<int> answers = new List<int> { 1 };
			TrueFalse test= new TrueFalse("Is this a question?:", answers);

			Assert.IsTrue(test.CorrectAnswer[0] == 1);
		}


		[TestMethod]
		public void TFQuestionGradesUserAnswer()
		{

			List<int> answers = new List<int> { 1 };
			TrueFalse test = new TrueFalse("Is this a question?:", answers);

			test.UserAnswer = new List<int> { 1 };
			Assert.IsTrue(test.GradeQuestion());

			test.UserAnswer[0] = 0;
			Assert.IsFalse(test.GradeQuestion());
		}

	}
}



		