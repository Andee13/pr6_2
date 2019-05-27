namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person ab = new Ab("mike", "Elit");
            Person student = new Student("Elit", 3, "Philip");
            Person techer = new Student("Elit", 3, "Mike");
            ab.get_info();
            student.get_info();
            techer.get_info();
        }
    }
}