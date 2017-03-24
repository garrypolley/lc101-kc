using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class RadioQuestion : QuizSet {
        private QuizAnswer _answer;

        public RadioQuestion(QuizAnswer answer) : base() {
            _answer = answer;
        }

        public override bool IsValidAnswers(List<QuizAnswer> answers) {
            if (answers.Count != 1) {
                return false;
            }

            return _answer.Equals(answers[0]);
        }

        public override List<QuizAnswer> ParseAnswer(string answer) {
            return new List<QuizAnswer>() {
                new QuizAnswer() { Value = answer}
            };
        }

        public override string ToString() {
            var quizQuestions = new StringBuilder();

            foreach (var choice in Choices) {
                var possibleAnswer = choice.Key.Value;
                var actualChoice = choice.Value.Value;
                quizQuestions.AppendLine($"{possibleAnswer}. {actualChoice}");
            }
            return $"{Question}:\n{quizQuestions}";
        }
    }
}