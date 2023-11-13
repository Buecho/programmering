using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int returnValue = random.Next(1,100);

            int guess = 0;

            Console.WriteLine("Gissa nummer från 1-100");
            
            while (guess != returnValue)
            {
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < returnValue)
                {
                    Console.WriteLine("Gissa högre tal");
                }
                else if (guess > returnValue)
                {
                    Console.WriteLine("Gissa lägre");
                }
                {
                    while (guess == returnValue)
                    {
                        Console.WriteLine("Du gissade rätt");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
