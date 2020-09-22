using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3_Built_In_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte A; //range -127 to +127
            byte B; //range 0 to 255
            char C; //range Unicode 16-bit character
            short D; //range -32768 to 32768
            ushort E; //range 0 to 65535
            int F; //range -2,147,483,648 to 2,147,483,647
            uint G; //range 0 to 4,294,967,295
            long H; //range -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong I; //range 0 to 18,446,744,073,709,551,615
            float J; //range ±1.5 x 10−45 to ±3.4 x 1038, precision: ~6-9 digits
            double K; //range ±5.0 × 10−324 to ±1.7 × 10308, precision: ~15-17 digits
            decimal L; //range ±1.0 x 10-28 to ±7.9228 x 1028, precision: 28-29 digits
        }
    }
}
