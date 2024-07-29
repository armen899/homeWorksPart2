namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           IStudent student = new Student("Aaaaaa", 10, 5);

            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Grade);
        }
    }

    public interface IStudent
    {
        string Name { get; }
        int Age { get; }
        int Grade { get;}
    }

    public class Student : IStudent
    { 
        public string Name { get;}
        public int Age { get;}
        public int Grade { get; }

        public Student(string name, int age, int grade) 
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
    }
}
