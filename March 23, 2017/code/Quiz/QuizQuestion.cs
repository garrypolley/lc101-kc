namespace Quiz
{
    public class QuizQuestion {
        public string Value {get; set;}

        public override bool Equals (object obj)
        {
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            QuizQuestion castQuestion = (QuizQuestion)obj;
            return Value.Equals(castQuestion.Value);
        }
    }
}