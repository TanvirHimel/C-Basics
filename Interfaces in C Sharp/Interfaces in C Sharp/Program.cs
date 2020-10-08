using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_in_C_Sharp
{
    //Interfaces are public by default
    //Interfaces cannot have a field or definition
    interface ICustomer1
    {
        void Print1();
    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }
    //If a class inherits from an interface then it must provide implementation for all interface members
    //A class can inherit from multiple interfaces
    //But a class cannot inherit from multiple classes
    class Customer : ICustomer2
    {
        public void Print2()
        {
            Console.WriteLine("Print - 2 Method");
        }

        public void Print1()
        {
            Console.WriteLine("Print-1 Method");
        }
    }
    //we can't create an instance of an interface but an interface reference variable can point to a derived class object
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Print1();
            C1.Print2();
        }
    }
}
