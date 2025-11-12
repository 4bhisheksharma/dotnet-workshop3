namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task3");

            Console.WriteLine("Enter your age: ");
            int age =  Convert.ToInt32(Console.ReadLine());

            if (age < 0)
            {
                throw new ArgumentOutOfRangeException("Age cannot be negative");
            }
            else if (age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 & age <= 19)
            {
                Console.WriteLine("Teenager");
            }

            else if (age >= 20){
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Kuch to gadbad hain Daya!");
            }
        }
    }
}
