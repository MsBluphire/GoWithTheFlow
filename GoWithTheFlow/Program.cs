using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWithTheFlow
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine ("Does the computer turn on?");
            Console.WriteLine("Please answer yes or no");
            Console.ReadLine();
            string answer = Console.ReadLine();
            if (answer == "yes")
                {
                Console.WriteLine("Great!");
            }
            else if(answer == "no")
                            {
                Console.WriteLine("Your computer is unplugged");
            }
            Console.ReadKey();
        }
    }
}
