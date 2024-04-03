namespace ConsoleApp67
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Circle circle = new Circle(4);
            Console.WriteLine($"Circle area: {circle.CalculateArea()}");


            Square square = new Square(5);
            Console.WriteLine($"Squeare area: {square.CalculateArea()}");
            Triangle triangle = new Triangle(3, 6);
            Console.WriteLine($"Triangle area: {triangle.CalculateArea()}");


        }
    }
}