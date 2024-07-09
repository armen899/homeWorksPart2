namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Person("AAA", "BB", 30),
                new Person("CCC", "DDD", 20),
                new Person("EEE", "FFF", 10),
                new Person("GGG", "HHHH", 40)
            };
            double personAverageAge = CalculatePersonsAverageAge(people);
            Console.WriteLine($"Perosns Average Age: {personAverageAge}");
        }

        public static double CalculatePersonsAverageAge(Person[] people)
        {
            int sumAge = 0;
            foreach (Person person in people)
            {
                sumAge += person.Age;
            }
            double averageAge = (double)sumAge / people.Length;
            return averageAge;
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
