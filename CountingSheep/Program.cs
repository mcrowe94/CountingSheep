using System;
using System.Threading;

namespace CountingSheep
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hey there! What's your name? You look pretty tired...");

            Console.WriteLine();

            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Well, {userName}, just close your eyes and begin counting sheep! How many hours would you like to sleep?");
            Console.WriteLine();

            int countSheep = int.Parse(Console.ReadLine());

            Console.WriteLine();
            {
                for (int i = 1; i <= countSheep; i++)
                {
                    Console.WriteLine($"{i} sheep....");
                    Thread.Sleep(800);
                }
                Console.WriteLine("...ZZZzzZZZzzzzzZZz.......");
            }
                

        }
    }

}      
    

