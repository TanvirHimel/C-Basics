using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit conversion
            int a = 200;
            float b = a;

            //Console.WriteLine(b);

            //Explicit conversion
            float c = 45.987F;
            //int d = (int)c;
            int d = Convert.ToInt32(c);
            //Console.WriteLine(d);

            string strNumber = "1000";

            int e = int.Parse(strNumber);
            //parse method returns string to integer
            int f = int.Parse(strNumber);
            string strNumber1 = "1000TH";

            int result = 0;
            //TryParse returns boolean value
            bool IsCorrectNumber = int.TryParse(strNumber1, out result);

            if (IsCorrectNumber)
                Console.WriteLine(strNumber1);
            else
                Console.WriteLine("Please enter a valid number.");
            //use parse() if you are sure the value will be valid, otherwise use TryParse() 
        }
    }
}
