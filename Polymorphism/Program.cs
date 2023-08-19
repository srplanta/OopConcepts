using Polymorphism;

internal class Program
{
    private static void Main(string[] args)
    {
        //Drawing rectangle = new Rectangle();
        //Drawing square = new Square();
        //Drawing circle= new Circle();

        //Console.WriteLine($"Rectangel Area:\t{rectangle.Area()}");
        //Console.WriteLine($"Square Area:\t{square.Area()}");
        //Console.WriteLine($"Circle Area:\t{circle.Area()}");


        Drawing rectangle = new Rectangle(4.5, 2.5);
        Drawing square = new Square(3.4);
        Drawing circle = new Circle(3.7);

        Console.WriteLine(rectangle.ToString());
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(square.ToString());
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(circle.ToString());
        Console.WriteLine("-------------------------------------");

        OperatorOverloading obj1 = new OperatorOverloading()
        {
            Fee = 1,
            Name="Amir"
        };
        OperatorOverloading obj2 = new OperatorOverloading()
        {
            Fee = 2,
            Name = "Mani"
        };

        OperatorOverloading obj3 = obj1 + obj2;
        Console.WriteLine(obj1.ToString());
        Console.WriteLine(obj2.ToString());
        Console.WriteLine(obj3.ToString());

        Console.ReadKey();
    }
}