namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IAnimal dog = new Dog();

            dog.Eat();

            dog.Sleep();
        }
    }

    public interface IAnimal
    {
        void Eat();
        void Sleep();
    }


    public class Dog : IAnimal
    {
        void IAnimal.Eat()
        {
            Console.WriteLine("IAnimal.Eat");
        }

        void IAnimal.Sleep()
        {
            Console.WriteLine("IAnimal.Sleep");
        }
    }

}
