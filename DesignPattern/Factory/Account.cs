using System;

namespace DesignPattern
{
    public class TeacherSubject : Subject
    {
        public void addSubject(string subjectName)
        {
            Console.WriteLine("Add subject: " + subjectName);
        }
    }
    public class StudentSubject : Subject
    {
        public void addSubject(string subjectName)
        {
            Console.WriteLine("You couldn't add subject, because you're a student! Don't try it again!");
        }
    }
}
