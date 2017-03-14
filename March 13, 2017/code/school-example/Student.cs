using System;

public class Student {

    private static Random rnd = new Random();

    public Student() {
        studentId = rnd.Next();
    }

    private int studentId;

    public string Name { get; set;}

    public int StudentId
    {
        get { return studentId; }
        private set { studentId = value; }
    }

    public int NumberOfCredits { get; set; }

    public double Gpa { get; set; }

    public override string ToString() {
        return string.Format("{0} ({1}) -- {2}/{3}",
            Name, StudentId, Gpa, NumberOfCredits);
    }

    public static double GenerateGpa() {
        int randInt = rnd.Next(0, 400);
        double gpa = randInt / 100;

        return gpa;
    }

}