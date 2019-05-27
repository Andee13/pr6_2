using System;

namespace ConsoleApplication2
{
    public abstract class Person
    {
        static Random r = new Random();
        private DateTime dt;
        
            
        
        private String surname;

        protected Person(string surname)
        {
            //Math.Abs(r.Next())%11 + 1
            dt = new DateTime(2008,3 , 1, 7, 47, 0);
            this.surname = surname;
        }

        public virtual void get_info()
        {
            Console.WriteLine($"Name of person is {surname}, he's age is {( DateTime.Now - dt ).Days/365} and {(dt - new DateTime()).Days%365} day");
        }
    }
}