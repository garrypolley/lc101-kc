using System.Collections.Generic;

namespace Quiz
{
    public class Generate {
        private static List<QuizAnswer> possibleChoices = new List<QuizAnswer>() {
            new QuizAnswer() {Value = "a"},
            new QuizAnswer() {Value = "b"},
            new QuizAnswer() {Value = "c"},
            new QuizAnswer() {Value = "d"},
            new QuizAnswer() {Value = "e"},
        };
        public static MultiQuestion MultiQuestion() {
            var answers = new List<QuizAnswer>() {
                new QuizAnswer() {Value = "a"},
                new QuizAnswer() {Value = "c"}
            };

            var question = new MultiQuestion(answers);

            question.Question = "This is a multi-question";

            foreach (var choice in possibleChoices)
            {
                question.AddChoice(choice, new QuizQuestion() { Value = $"Fake choice for --{choice.Value}--"});
            }
            return question;
        }

        public static RadioQuestion RadioQuestion() {
            var question = new RadioQuestion(new QuizAnswer() {Value = "c"});

            question.Question = "This is a radio-question";

            foreach (var choice in possibleChoices)
            {
                question.AddChoice(choice, new QuizQuestion() { Value = $"Fake choice for --{choice.Value}--"});
            }
            return question;
        }

        public static TrueFalseQuestion TrueFalseQuestion() {
            var question = new TrueFalseQuestion(true);

            question.Question = "This is a boolean question";
            return question;
        }
    }
}