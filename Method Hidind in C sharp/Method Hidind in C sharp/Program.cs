using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hidind_in_C_sharp
{
    public class Employee
    {
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        { 
            Console.WriteLine(FirstName +" " + LastName);
        }
    }

    public class FullTimeEmploye : Employee
    {

    }

    public class PartTimeEmployee : Employee
    {

        //If you want to hide a base class member then use new keyword
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Contractor");
        }

        //If you want get base class PrintFullMethod()
        //base.PrintFullName();
    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmploye FTE = new FullTimeEmploye();

            //to get the base PrintFullName method (1st method)
            //Employee PTE = new PartTimeEmployee();
            PartTimeEmployee PTE = new PartTimeEmployee();

            FTE.FirstName = "Donald";
            FTE.LastName = "Trump";
            FTE.PrintFullName();

            PTE.FirstName = "Joe";
            PTE.LastName = "Biden";
            PTE.PrintFullName();
            //to get the base PrintFullName method (2nd method)
            //((Employee)PTE).PrintFullName();
        }
    }
}
