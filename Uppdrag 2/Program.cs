using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 65;
            Console.WriteLine("vad heter du");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("Hur gammal är du");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);

            Console.WriteLine("du tar pensionär om" + (x-age) + "år");
                
        }
    }
}
