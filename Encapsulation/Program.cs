namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = 4.5;
            rectangle.Width = 3.2;
            rectangle.DisplayRectangle();
            Console.ReadKey();
        }
    }
}