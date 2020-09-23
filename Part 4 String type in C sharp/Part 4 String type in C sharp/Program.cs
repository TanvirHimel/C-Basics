using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4_String_type_in_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "\"Kudvengkat\"\n";
            string name2 = "One\nTwo\nThree\n";
            //if there is @ before any string then visual studio ignores all the escape sequences within the strings
            //which is known as Varbatim Literal
            string name3 = @"C:\Users\USER\source\repos\Kudvenkat";
            Console.Write(name);
            Console.Write(name2);
            Console.WriteLine(name3);
        }
    }
}
