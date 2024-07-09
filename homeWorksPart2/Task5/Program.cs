namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Address address = new Address("Yerevan", "Azatutyan 9", "0002");


            Person person = new Person("Armen", address);

            Console.WriteLine(person.DisplayPerson());
        }
    }

    public struct Address
    {
        public string City;
        public string Street;
        public string PostalCode;


        public Address(string  city, string street, string postalCode)
        {
            City = city;
            Street = street;
            PostalCode = postalCode;
        }
        public string DisplayAddress()
        {
            return $"Address: {Street}, {City}, {PostalCode}";
        }

    }

    public struct Person
    {
        public string Name;
        public Address Address;
        public Person(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public string DisplayPerson()
        {
            return $"Name: {Name}, Address: {Address.DisplayAddress()}";
        }
    }
}
