using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding_VS_Method_Hiding
{
    //To override use "override keyword"
    //To hide use "new keyword"
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Base class method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("Derived class method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass B = new DerivedClass();
            B.Print();
        }
    }
}
