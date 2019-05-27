using System;

namespace ConsoleApplication2
{
    public class Teacher:Person
    {
        private String faculty;
        private String rang;
        private int yearsOfWorking;

        public string Faculty
        {
            get => faculty;
            set => faculty = value;
        }

        public string Rang
        {
            get => rang;
            set => rang = value;
        }

        public int YearsOfWorking
        {
            get => yearsOfWorking;
            set => yearsOfWorking = value;
        }

        public Teacher(String faculty, String rang, int yearsOfWorking, String surname):base(surname)
        {
            this.faculty = faculty;
            this.rang = rang;
            this.yearsOfWorking = yearsOfWorking;
        }

        public void get_info()
        {
            get_info();
            Console.WriteLine($"The faculty of this professor is {faculty}, his rang is {rang}, he is working for {yearsOfWorking}");
        }
    }
}