namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point { X = 10, Y = 20 };
            ModifyPointByValue(ref point);
            Console.WriteLine($"Original Point: X={point.X}, Y={point.Y}");
        }

        public static void ModifyPointByValue(ref Point p)
        {
            p.X = 100;
            p.Y = 200;
            Console.WriteLine($"Modified Point: X={p.X}, Y={p.Y}");
        }
    }

    public struct Point
    {
        public int X;
        public int Y;
    }


}
