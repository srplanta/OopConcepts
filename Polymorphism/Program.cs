using Polymorphism;

internal class Program
{
    private static void Main(string[] args)
    {
        Drawing rectangle = new Rectangle();
        Drawing square = new Square();
        Drawing circle= new Circle();

        Console.WriteLine($"Rectangel Area:\t{rectangle.Area()}");
        Console.WriteLine($"Square Area:\t{square.Area()}");
        Console.WriteLine($"Circle Area:\t{circle.Area()}");

        Console.ReadKey();
    }
}