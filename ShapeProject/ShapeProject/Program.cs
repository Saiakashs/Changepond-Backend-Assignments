namespace ShapeProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Shape r = new Rectangle(5.5, 6.5);
            Console.WriteLine("Area: "+r.Area());
            Console.WriteLine("Perimeter: "+r.Perimeter());

            Shape c = new Circle(3);
            Console.WriteLine("Area: " + c.Area());
            Console.WriteLine("Perimeter: " + c.Perimeter());

        }
    }
}
