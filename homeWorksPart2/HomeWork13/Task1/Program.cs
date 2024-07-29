namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IShape circle = new Circle(10);

            var c = circle.CalculateArea();


            IShape rectangle = new Rectangle(10, 20);

            var r = rectangle.CalculateArea();

            Console.WriteLine(c);
            Console.WriteLine(r);
        }
    }

    public interface IShape
    {
        public double CalculateArea();
    }

    public class Circle : IShape
    {
        public double Radius { get;}

        public Circle (double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }

    public class Rectangle : IShape
    {
        public double Width { get;}

        public double Length { get;}


        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public double CalculateArea()
        {
            return Width * Length;
        }

    }
}
