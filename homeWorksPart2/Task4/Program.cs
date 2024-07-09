namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(3, 5);


            Point point2 = new Point(4, 8);


           Console.WriteLine(point1 != point2);


            var point3 = point1 + point2;

           Console.WriteLine($"{point3.X} {point3.Y}");

        }
    }


    public struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }


        public static bool operator == (Point point1, Point point2) 
        {
            return point1.X == point2.X && point1.Y == point2.Y;
        }

        public static bool operator != (Point point1, Point point2)
        {
            return !(point1 == point2);
        }

        public static Point operator +(Point point1, Point point2)
        {
            return new Point(point1.X + point2.X, point1.Y + point2.Y);
        }

    }

}
