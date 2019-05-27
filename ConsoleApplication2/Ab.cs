using System;

namespace ConsoleApplication2
{
    public class Ab:Person
    {
        
        private String faculty;

        public string Faculty
        {
            get => faculty;
            set => faculty = value;
        }

        public Ab(String  surname, String faculty) : base(surname)
        {
            this.faculty = faculty;
        }

        public void get_info()
        {
            get_info();
            Console.WriteLine($"This person is abiturient, faculty is {faculty}\n");
        }
        
    }
}