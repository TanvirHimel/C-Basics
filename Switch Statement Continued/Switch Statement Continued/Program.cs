using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement_Continued
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalCofeeCost = 0;

            //we should avoid goto because it makes your program more complex to debug

            Start:
            Console.WriteLine("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large");
            int UserChoice = int.Parse(Console.ReadLine());

            switch(UserChoice)
            {
                case 1:
                    TotalCofeeCost += 1;
                    break;
                case 2:
                    TotalCofeeCost += 2;
                    break;
                case 3:
                    TotalCofeeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", UserChoice);
                    goto Start;
            }

            Decision:
            Console.WriteLine("Do you want to buy another coffee? - Yes or No");
            string UserInput = Console.ReadLine();

            switch(UserInput.ToLower())
            {
                case "yes":
                    goto Start;
                case "no":
                    break;
                default:
                    Console.WriteLine("Your choice {0} i invlaid, plz try again...",UserInput);
                    goto Decision;
            }

            Console.WriteLine("Thank you for shoppig with us");
            Console.WriteLine("Bill amount = {0}", TotalCofeeCost);
        }
    }
}
