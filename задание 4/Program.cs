using System;

namespace задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the speed limit: ");
            string? limitStr = Console.ReadLine();
            int limitInt = Convert.ToInt32(limitStr);

            Console.Write("Enter the speed of a car: ");
            string? speedStr = Console.ReadLine();
            int speedInt = Convert.ToInt32(speedStr);

            if (limitInt >= speedInt)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int fpoint = (speedInt - limitInt)/ 5;
                if (fpoint > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                { 
                    Console.WriteLine(fpoint); 
                }
            }


        }
    }
}