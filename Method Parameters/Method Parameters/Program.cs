using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Parameters
{
    class Program
    {
        /*
         * Passing the parameter byy value
        static void Main(string[] args)
        {
            int j = 5;

            SimpleMethod(j);
            Console.WriteLine(j);
        }

        public static void SimpleMethod(int i)
        {
            i = 10 * i;
        }
        */

        //Passing the parameter by reference
        //static void Main(string[] args)
        //{
        //    int j = 5;

        //    SimpleMethod(ref j);
        //    Console.WriteLine(j);
        //}

        //public static void SimpleMethod(ref int i)
        //{
        //    i = 10 * i;
        //}

        ////Out Parameter
        //static void Main(string[] args)
        //{
        //    int Total = 0;
        //    int Product = 0;

        //    Calculate(10, 20, out Total, out Product);
        //    Console.WriteLine("Sum = {0}  and Product = {1}", Total, Product);
        //}

        //public static void Calculate(int FN, int SN, out int Sum, out int Product)
        //{
        //    Sum = FN + SN;
        //    Product = SN * FN;
        //}

        //Parameter Arrays
        static void Main(string[] args)
        {
            int[] Numbers = new int[3];

            Numbers[0] = 123;
            Numbers[1] = 456;
            Numbers[2] = 789;

            ParamsMethod(Numbers);
        }

        public static void ParamsMethod(params int[] Numbers)
        {
            foreach(int k in Numbers)
            {
                Console.WriteLine(k);
            }
        }
    }
}
