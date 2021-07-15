using System;

namespace Try_Catch_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message.ToString());

            }
            finally
            {
                Console.WriteLine("Completed!!");
            }

            try
            {
                int a = int.Parse(null);
                
            }
            catch(ArgumentNullException exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
