using Abstraction_Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Implementing OOP concept of Abstraction by using Interfaces!");
        //Console.WriteLine("------------------------------------------------------------");
        //Console.WriteLine();

        //IDrawable circle = new Circle();
        //IDrawable square = new Square();
        //IDrawable rectangle = new Rectangle();
        //circle.Draw();
        //square.Draw();
        //rectangle.Draw();

        Console.WriteLine("Implementing OOP concept of Abstraction by using Abstract Class!");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine();

        Student student = new Student();
        student.Id = -22;
        student.Name = "Anas";
        Console.WriteLine($"Id:\t{student.Id}");
        Console.WriteLine($"Name:\t{student.Name}");
        Console.ReadKey();
    }
}

