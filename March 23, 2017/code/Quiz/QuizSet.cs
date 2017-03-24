using System.Collections.Generic;

namespace Quiz
{
    public abstract class QuizSet {

        public List<QuizAnswer> Answers;
        public Dictionary<QuizAnswer, QuizQuestion> Choices { get; private set; }
        public string Question;

        public QuizSet() {
            Answers = new List<QuizAnswer>();
            Choices = new Dictionary<QuizAnswer, QuizQuestion>();
        }

        public QuizAnswer GetChoice(string value) {
            return Answers.Find(a => a.Value.Equals(value));
        }

        public virtual void AddChoice(QuizAnswer answer, QuizQuestion question) {
            Choices.Add(answer, question);
        }

        public void AddAnswer(QuizAnswer answer) {
            Answers.Add(answer);
        }

        public abstract bool IsValidAnswers(List<QuizAnswer> answers);

        public abstract List<QuizAnswer> ParseAnswer(string answer);
    }
}