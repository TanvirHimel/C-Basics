using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interfaces_Implementation
{
    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }

    public class Program : I1, I2
    {
        //explicitly interface names are used to remove ambiguity
        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 interface method");
        }
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 interface method");
        }
        //Access modifiers are not allowed
        static void Main(string[] args)
        {
            //1st way
            //Program P = new Program();

            //((I1)P).InterfaceMethod();
            //((I2)P).InterfaceMethod();


            //2nd way
            I1 i1 = new Program();
            I2 i2 = new Program();

            i1.InterfaceMethod();
            i2.InterfaceMethod();
        }
    }
}
