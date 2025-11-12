using System.Text.Json.Serialization.Metadata;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, from task 1");

            var ops = new Operators();

            int a = 26;
            int b = 4;
            int number = 15;

            Console.WriteLine($"Add: {ops.Add(a, b)}");
            Console.WriteLine($"Subtract: {ops.Subtract(a, b)}");
            Console.WriteLine($"Multiply: {ops.Multiply(a, b)}");
            Console.WriteLine($"Divide: {ops.Divide(a, b)}");

            ops.OddEvenFinder(number);
        }
    }
}