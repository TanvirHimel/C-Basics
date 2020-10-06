using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_To_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.PrintFullName();

            Customer C2 = new Customer("Tanvir", "Himel");
            C2.PrintFullName();
        }
    }

    class Customer
    {
        string _firstName;
        string _lastName;

        public Customer(string FirstName, string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        public Customer()
            :this("No First Name", "No Last Name")
        {

        }

        public void PrintFullName()
        {
            Console.WriteLine("Full name: {0}" , this._firstName + " " + this._lastName);
        }

        ~Customer()
        {
            //clean up code
        }
    }
}
