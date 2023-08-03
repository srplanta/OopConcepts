using Abstraction_Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        IEmployee partTimeEmployee = new PartTimeEmployee();
        partTimeEmployee.ShowEmployee();
        Console.ReadKey();
    }
}