internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, from method hiding!");

        Child child = new Child();
        child.Show();               //child class method

        //call parent class method
        Parent parent = new Child();
        parent.Show();              //parent class method
        ((Parent)child).Show();     //parent class method
        
        Console.ReadLine();
    }
}

// *********** Method Hiding **************
public class Parent
{
    public void Show()
    {
        Console.WriteLine("Parent class method!");
    }
}

public class Child : Parent
{
    public new void Show()
    {
        Console.WriteLine("Child class method!");
    }
}