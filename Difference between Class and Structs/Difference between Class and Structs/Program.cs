using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_between_Class_and_Structs
{
    //Structs cant have destructors but classes can
    //Structs cant have explicit paremeterless constructors but classes can
    //Structs cant inherit from another class bus a class can
    //Use "sealed" keyword is used to prevent your class inherited to other and structs are inherently sealed types

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Value types
            //when you copy a struct into another struct a new copy of struct is created and modification in one won't effect another one
            int i = 10;
            int j = i;

            j = j + 1;
            Console.WriteLine(" i = {0} and j = {1}", i, j);

            //reference type
            //when you copy a reference variable into another a new copy of wont created and modification in one will effect another one
            Customer C1 = new Customer();
            C1.Name = "ABC";
            C1.ID = 100;

            Customer C2 = C1;
            C2.Name = "XYZ";
            Console.WriteLine("C1.Name = {0}, C2.Name = {1}", C1.Name, C2.Name);
            //int i = 0;

            //if(i == 10)
            //{
            //    int j = 0;
            //    Customer C1 = new Customer();
            //    C1.ID = 10;
            //    C1.Name = "Tay";
            //    Console.WriteLine(" Name = {0}, Id = {1}", C1.ID, C1.Name);
            //}
        }
    }
}
