namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task4");

            Console.WriteLine("Enter day as number (1-7): ");

            int day = Convert.ToInt32(Console.ReadLine());
            string dayName = day switch
            {
                1 => "Sunday",
                2 => "Monday",
                3 => "Tuesday",
                4 => "Wednesday",
                5 => "Thursday",
                6 => "Friday",
                7 => "Saturday",
                _ => "Invalid day number"
            };

            Console.WriteLine($"Day is: {dayName}");

        }
    }
}
