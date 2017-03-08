using System.Collections.Generic;
using System.Text;

public class Course {
    public List<Student> Students { get; private set; }

    public void AddStudent(Student student) {
        if (Students == null) {
            Students = new List<Student>();
        }
        // Students with a name starting with "g" are not allowed in the course
        if (!student.Name.ToLower().StartsWith("g"))
        {
            Students.Add(student);
        }
    }

    public string Name { get; set; }

    public int NumberOfStudents
    {
        get {
            return Students.Count;
        }
    }

    public override string ToString() {
        StringBuilder courseRep = new StringBuilder();

        courseRep.AppendLine(string.Format("Course: {0}", Name));
        courseRep.AppendLine(string.Format("       Count: {0}", NumberOfStudents));
        courseRep.AppendLine(string.Format("       Students:"));

        foreach (var student in Students)
        {
            courseRep.AppendLine(string.Format("              {0}", student));
        }

        return courseRep.ToString();
    }
}