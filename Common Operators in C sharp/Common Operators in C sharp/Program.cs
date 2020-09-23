using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Operators_in_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator = 10;
            int denominator = 5;

            int division = numerator / denominator;
            int modulas = numerator % denominator;

            Console.WriteLine(" Division of {0} and {1} is {2} and modulas is {3}", numerator, denominator, division, modulas);

            if(numerator == 5 || denominator == 10 && numerator<denominator)
            {
                Console.WriteLine(" {0}/{1} is a proper fraction", numerator, denominator);
            }
            else
                Console.WriteLine(" {0}/{1} is an improper fraction", numerator, denominator);
            bool IsNumber10 = numerator == 10 ? true : false;
            Console.WriteLine(" IsNumber10 is {0}", IsNumber10);
        }
    }
}
