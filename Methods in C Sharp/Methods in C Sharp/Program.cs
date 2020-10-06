using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_in_C_Sharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program.OddNumbers(50);
            Program p = new Program();
            int sum = p.Add(20, 50);
        }

        public int Add(int FN, int SN)
        {
            return FN + SN;
        }

        public static void OddNumbers(int Target)
        {
            int Start = 1;

            while(Start <= Target)
            {
                Console.WriteLine(Start);
                Start += 2;
            }
        }
    }
}
