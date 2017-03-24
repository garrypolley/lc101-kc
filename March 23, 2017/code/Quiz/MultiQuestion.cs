using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class MultiQuestion : QuizSet {
        private List<QuizAnswer> _answers;

        public MultiQuestion(List<QuizAnswer> answers) : base() {
            _answers = answers;
        }

        public override bool IsValidAnswers(List<QuizAnswer> answers) {
            bool isValid = true;

            // Validate we have the same length of answers given and actual answers.
            if (answers.Count != _answers.Count) {
                isValid = false;
            } else {
                // go over each answer, if one of them is not inside our actual answers
                // then the correct answers were not chosen.
                foreach (var answer in answers)
                {
                    if (!_answers.Contains(answer)) {
                        isValid = false;
                    }
                }
            }

            return isValid;
        }

        public override List<QuizAnswer> ParseAnswer(string answer) {
            var answers = new List<QuizAnswer>();
            foreach (var item in answer.Split(','))
            {
                answers.Add(new QuizAnswer() {Value = item});
            }
            return answers;
        }

        public override string ToString() {
            var quizQuestions = new StringBuilder();

            foreach (var choice in Choices) {
                var possibleAnswer = choice.Key.Value;
                var actualChoice = choice.Value.Value;
                quizQuestions.AppendLine($"{possibleAnswer}. {actualChoice}");
            }
            return $"{Question} (separate answers with ','):\n{quizQuestions}";
        }
    }
}