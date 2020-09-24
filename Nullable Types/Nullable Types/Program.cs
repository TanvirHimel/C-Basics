using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            int i = 0;
            //to store null values in a varibale put question mark after data type
            int? j = null;

            bool? IsMajor = null;
            
            if (IsMajor == true)
            {
                Console.WriteLine("User is major.");
            }
            else if (IsMajor == false)
            {
                Console.WriteLine("User is not major.");
            }
            else
                Console.WriteLine("User did not answer the question.");

            NullaBleType2 nul = new NullaBleType2();

            nul.Nullable();
        }
    }
}
