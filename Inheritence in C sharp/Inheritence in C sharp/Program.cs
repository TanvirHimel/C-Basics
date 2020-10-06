 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_in_C_sharp
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent class constructor called");
        }

        public ParentClass(string Msg)
        {
            Console.WriteLine(Msg);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Derived class controlling Parent class")
        {
            Console.WriteLine("Child class constructor called");
        }
    }

    //public class Employee
    //{
    //    public string FirstName;
    //    public string LastName;
    //    public string Email;

    //    public void PrintFullName()
    //    {
    //        Console.WriteLine(FirstName + " " + LastName);
    //    }
    //}

    //public class FullTimeEmployee : Employee
    //{
    //    public float YearlySalary;
    //}

    //public class PartTimeEmployee : Employee
    //{
    //    public float HourlyRate;
    //}

    ////Multi level inheritence
    //public class A : PartTimeEmployee
    //{

    //}

    class Program
    {
        static void Main(string[] args)
        {
            ChildClass CC = new ChildClass();

            //FullTimeEmployee FTE = new FullTimeEmployee();
            //FTE.FirstName = "Tanvir";
            //FTE.LastName = "Himel";
            //FTE.Email = "tanvirahimel@gmail.com";
            //FTE.YearlySalary = 80000;
            //FTE.PrintFullName();

            //PartTimeEmployee PTE = new PartTimeEmployee();
            //PTE.FirstName = "Donald";
            //PTE.LastName = "Trump";
            //PTE.Email = "djt@gmail.com";
            //PTE.HourlyRate = 30000;
            //PTE.PrintFullName();
        }
    }
}
