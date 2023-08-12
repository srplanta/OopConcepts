using Abstraction_Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Implementing OOP concept of Abstraction by using Interfaces!");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine();

        IDrawable circle = new Circle();
        IDrawable square = new Square();
        IDrawable rectangle = new Rectangle();
        circle.Draw();
        square.Draw();
        rectangle.Draw();
        Console.ReadKey();
    }
}

