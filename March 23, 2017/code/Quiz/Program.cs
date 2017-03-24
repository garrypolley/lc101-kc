using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            var mq = Generate.MultiQuestion();
            var rq = Generate.RadioQuestion();
            var bq = Generate.TrueFalseQuestion();

            Console.WriteLine("You shall take a quiz\n\n");

            Console.WriteLine(mq);
            var mqAnswerText = Console.ReadLine();
            var mqAnswers = mq.ParseAnswer(mqAnswerText);
            Console.WriteLine(IsCorrectOutput(mq, mqAnswers));

            Console.WriteLine(rq);
            var rqAnswerText = Console.ReadLine();
            var rqAnswers = rq.ParseAnswer(rqAnswerText);
            Console.WriteLine(IsCorrectOutput(rq, rqAnswers));

            Console.WriteLine(bq);
            var bqAnswerText = Console.ReadLine();
            var bqAnswers = bq.ParseAnswer(bqAnswerText);
            Console.WriteLine(IsCorrectOutput(bq, bqAnswers));
        }

        static string IsCorrectOutput(QuizSet quizset, List<QuizAnswer> answers) {
            if (quizset.IsValidAnswers(answers)) {
                return "Correct!\n\n";
            }
            return "Incorrect\n\n";
        }
    }
}
