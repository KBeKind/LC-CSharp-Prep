// See https://aka.ms/new-console-template for more information
using CSharpStudioChap7Quiz;
using System.ComponentModel.Design;

Console.WriteLine("Hello, Quizzer!");
Console.WriteLine("Answer with the number of the answer.");


Quiz aQuiz = new Quiz();


MultiChoice question1 = new MultiChoice("What is the best color?:", new List<int> {1});
question1.PossibleAnswers = new List<string>() {"Green", "Blue", "Red", "Yellow"};


TrueFalse question2 = new TrueFalse("Is this a question?:", new List<int> { 1 });
question2.PossibleAnswers = new List<string>() { "True", "False" };

Checkbox question3 = new Checkbox("What is divisible by 3?:", new List<int> { 1, 3, 4 });
question3.PossibleAnswers = new List<string>() { "3", "10", "15", "27" };

MultiChoice question4 = new MultiChoice("Who is the best kitty?:", new List<int> { 3 });
question4.PossibleAnswers = new List<string>() { "Grumpy Cat", "Nala", "Reiki", "Felix" };


aQuiz.Questions.Add(question1);
aQuiz.Questions.Add(question2);
aQuiz.Questions.Add(question3);
aQuiz.Questions.Add(question4);



for (int i = 0; i < aQuiz.Questions.Count; i++)
{

    Console.WriteLine($"{i + 1}. {aQuiz.Questions[i].QuestionText} \n {aQuiz.Questions[i].Directions}");
    for (int j = 0; j < aQuiz.Questions[i].PossibleAnswers.Count; j++)
    {
        Console.WriteLine($"   {j + 1}: {aQuiz.Questions[i].PossibleAnswers[j]}");
    }
    Console.WriteLine("Your Answer:");
    if (aQuiz.Questions[i] is Checkbox) {
        string answer = Console.ReadLine();

        string[] answerArray = answer.Split(" ");

        foreach (string a in answerArray)
        {

            aQuiz.Questions[i].UserAnswer.Add(int.Parse(a));
		}
       
    } else {
	aQuiz.Questions[i].UserAnswer.Add(int.Parse(Console.ReadLine()));

    }
    
    if (aQuiz.Questions[i].GradeQuestion())
    {
        aQuiz.Score++;
    }
}


Console.WriteLine($"Your score is: {aQuiz.Score}/{aQuiz.Questions.Count}");