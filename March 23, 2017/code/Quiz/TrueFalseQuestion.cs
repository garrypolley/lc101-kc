using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class TrueFalseQuestion : QuizSet {
        private QuizAnswer _answer;
        private static List<string> affirmativeAnswers =  new List<string>() {"y", "yes", "true", "t"};
        private static List<string> negativeAnswers =  new List<string>() {"n", "no", "false", "f"};

        public TrueFalseQuestion(bool answer) : base() {
            _answer = new QuizAnswer() { Value = answer.ToString() } ;
        }

        public override List<QuizAnswer> ParseAnswer(string answer) {
            var boolAnswer = false;

            if (affirmativeAnswers.Contains(answer)) {
                boolAnswer = true;
            }
            return new List<QuizAnswer>() {
                new QuizAnswer() { Value = boolAnswer.ToString() }
            };
        }

        public override bool IsValidAnswers(List<QuizAnswer> answers) {
            if (answers.Count != 1) {
                return false;
            }

            return _answer.Equals(answers[0]);
        }

        public override string ToString() {
            var quizQuestions = new StringBuilder();

            return $"{Question}:\n true or false?";
        }
    }
}