using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Loop_In_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string UserChoice = "";
            do
            {
                Console.WriteLine("Please enter your target: ");
                int UserInput = int.Parse(Console.ReadLine());

                int Start = 0;

                while (Start <= UserInput)
                {
                    Console.Write(Start + " ");
                    Start += 2;
                }

                do
                {
                    Console.WriteLine("Do you want to continue? Yes or No");
                    UserChoice = Console.ReadLine().ToUpper();

                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice, please say yes or no");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES");
            */

            //Coffee shop using do while loop
            int TotalCost = 0;
            string UserDecision = string.Empty;

            do
            {
                int UserChoice = -1;
                do
                {
                    Console.WriteLine("Please enter your Coffee size: 1 - Small, 2 - Medium, 3 - Large");
                    UserChoice = int.Parse(Console.ReadLine());

                    switch (UserChoice)
                    {
                        case 1:
                            TotalCost += 1;
                            break;
                        case 2:
                            TotalCost += 2;
                            break;
                        case 3:
                            TotalCost += 3;
                            break;
                        default:
                            Console.WriteLine("Your choice {0} is invalid.", UserChoice);
                            break;
                    }
                } while (UserChoice != 1 && UserChoice != 2 && UserChoice != 3);

                do
                {
                    Console.WriteLine("Do you want to buy another coffee? Yes or No");
                    UserDecision = Console.ReadLine().ToUpper();

                    if (UserDecision != "YES" && UserDecision != "NO")
                    {
                        Console.WriteLine("Your choice {0} is invalid, please try again .....", UserDecision);
                    }
                } while (UserDecision != "YES" && UserDecision != "NO");
            } while (UserDecision.ToUpper() != "NO");

            Console.WriteLine("Thank you for shopping with us.");
            Console.WriteLine("Your bill is {0}", TotalCost);
        }
    }
}
