using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number: ");
            int UserNumber = int.Parse(Console.ReadLine());

            if (UserNumber == 1)
                Console.WriteLine(" Your number is 1");
            else if(UserNumber == 2)
                Console.WriteLine("Your number is 2");
            else if(UserNumber == 3)
                Console.WriteLine("Your number is 3");
            else
                Console.WriteLine("Your number is not in between 1 and 3");
            if (UserNumber == 1 || UserNumber ==2 || UserNumber == 3)
                Console.WriteLine("Your number is {0}", UserNumber);
            else
                Console.WriteLine("Your number is not in between 1 and 3");
        }
    }
}
