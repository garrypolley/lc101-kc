namespace student_example {
    public class Student {

        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        private Student() {}

        private Student(string name, int studentId,
                int numberOfCredits, double gpa) : this() {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        private Student(string name, int studentId)
            : this(name, studentId, 0, 0d) {}

        public Student(string name)
            : this(name, nextStudentId) {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade) {
            // Update the appropriate fields: numberOfCredits, gpa

            var existingQualityScore = Gpa * NumberOfCredits;
            var newClassScore = courseCredits * grade;

            NumberOfCredits += courseCredits;

            Gpa = (existingQualityScore +  newClassScore) / NumberOfCredits;
        }

        public string GetGradeLevel() {
            if (NumberOfCredits <= 29) {
                return "freshman";
            } else if (30 <= NumberOfCredits && NumberOfCredits <= 59) {
                return "sophomore";
            } else if (60 <= NumberOfCredits && NumberOfCredits <= 89) {
                return "junior";
            }
            return "senior";
        }

        public override string ToString() {
            return $"{Name} ({StudentId}) -- {GetGradeLevel()}({NumberOfCredits})";
        }

        public override bool Equals(object obj) {
            var otherStudent = (Student) obj;
            if (otherStudent == null) {
                return false;
            }
            return StudentId.Equals(otherStudent.StudentId);
        }

    }
}