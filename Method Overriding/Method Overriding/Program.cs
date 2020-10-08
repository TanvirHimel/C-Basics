using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void Add(int FN, int LN)
        {
            Console.WriteLine(" Sum = {0}", FN+LN);
        }

        public static void Add(int FN, float LN)
        {
            Console.WriteLine(" Sum = {0}", FN + LN);
        }

        public static void Add(float FN, float LN)
        {
            Console.WriteLine(" Sum = {0}", FN + LN);
        }

        ////It's not possible to overload a function just based on return type
        ///Also it's not possible to overload a function just based on params keywords
        ///so this overloading method will give build errors
        //public static int Add(float FN, float LN)
        //{
        //    Console.WriteLine(" Sum = {0}", FN + LN);
        //    return FN + LN;
        //}
    }
}
