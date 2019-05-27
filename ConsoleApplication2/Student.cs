using System;

namespace ConsoleApplication2
{
    public class Student:Person
    {
        private String faculty;
        private int curs;

        public string Faculty
        {
            get => faculty;
            set => faculty = value;
        }

        public int Curs
        {
            get => curs;
            set => curs = value;
        }

        public Student(String faculty, int curs, String surname):base(surname)
        {
            this.faculty = faculty;
            this.curs = curs;
        }

        public void get_info()
        {
            get_info();
            Console.WriteLine($"He is a student of {faculty}, {curs} curs\n");
        }
    }
}