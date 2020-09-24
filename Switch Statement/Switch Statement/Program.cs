using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int UserNumber =  int.Parse(Console.ReadLine());

            switch (UserNumber)
            {
                case 10: 
                    Console.WriteLine("Your number is 10");
                    break;
                case 9:
                    Console.WriteLine("Your number is 9");
                    break;
                case 8:
                    Console.WriteLine("Your number is 8");
                    break;
                case 7:
                    Console.WriteLine("Your number is 7");
                    break;
                case 6:
                    Console.WriteLine("Your number is 6");
                    break;
                case 5:
                    Console.WriteLine("Your number is 5");
                    break;
                case 4:
                    Console.WriteLine("Your number is 4");
                    break;
                case 3:
                    Console.WriteLine("Your number is 3");
                    break;
                case 2:
                    Console.WriteLine("Your number is 2");
                    break;
                case 1:
                    Console.WriteLine("Your number is 1");
                    break;
                default:
                    Console.WriteLine("Your number is not in between 1 and 9");
                    break;

            //Another way
                    /*
                     switch (UserNumber)
                    {
                        case 10:
                        case 9:
                        case 8:
                        case 7:
                        case 6:
                        case 5:
                        case 4:
                        case 3:
                        case 2:
                        case 1:
                            Console.WriteLine("Your number is {0}", UserNumber);
                            break;
                        default:
                            Console.WriteLine("Your number is not in between 1 and 9");
                            break;
                    */
}
}
}
}
