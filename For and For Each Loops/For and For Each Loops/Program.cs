using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_and_For_Each_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arrays = new int[5];

            Arrays[0] = 102;
            Arrays[1] = 203;
            Arrays[2] = 204;
            Arrays[3] = 205;
            Arrays[4] = 206;

            foreach(int k in Arrays)
            {
                Console.WriteLine(k);
                if (k == 2)
                    break;
            }

            int i = 0;
            while (i < Arrays.Length)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(Arrays[i]);
                i++;
            }
        }
    }
}
