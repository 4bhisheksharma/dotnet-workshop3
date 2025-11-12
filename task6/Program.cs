using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to convert to integer: ");
            try
            {
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input); 
                Console.WriteLine($"You entered: {number}");
            }
            catch (FormatException)
            {
              
                Console.WriteLine("Invalid number format");
            }
            finally
            {
               
                Console.WriteLine("Program Executed");
            }

           

            //password check
            Console.WriteLine("Enter a password: ");
            try
            {
                string password = Console.ReadLine();

         
                if (password.Length < 6)
                {
                    
                    throw new ArgumentException("Password must be at least 6 characters.");
                }
                else
                {
                    
                    Console.WriteLine("Password satisfied the requirement");
                }
            }
            catch (ArgumentException ex)
            {
            
                Console.WriteLine(ex.Message);
            }
        }
    }
}
