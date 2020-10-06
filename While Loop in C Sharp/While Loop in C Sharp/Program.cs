using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int UserInput = int.Parse(Console.ReadLine());

            int Start = 0;

            while (Start <= UserInput)
            {
                Console.Write(Start + " ");
                Start += 2;
            }
        }
    }
}
