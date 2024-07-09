namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("AAA", "BBBBB", 22);

            Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Age}");
        }
    }

    public struct Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

    }
}
