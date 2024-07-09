namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "AAA";
            person.LastName = "BBB";
            person.Age = 20;

            Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Age}");
        }
    }



    public struct Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
       
    }



}
