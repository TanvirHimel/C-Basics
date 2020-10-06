using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA = ProjectA.TeamA;
using TB = ProjectA.TeamB;

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            TA.ClassA.Print();
            TB.ClassA.Print();
        }
    }
}


