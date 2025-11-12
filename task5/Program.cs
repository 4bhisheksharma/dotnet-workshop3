namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task5");

           
            Console.WriteLine("Input any number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int resultIs = 0;

            for (int i = 1; i <= n; i++)
            {
                resultIs += i;
            }
            Console.WriteLine($"Sum from 1 to {n} is: {resultIs}");

            int num = 1;
            while (num <= 20)
            {
                // Skip multiples of 4
                if (num % 4 == 0)
                {
                    num++; 
                    continue;
                }

                // Break the loop when num is 15
                if (num == 15)
                {
                    break;
                }

                Console.WriteLine(num);

              
                num++;
            }
        }
    }
}
