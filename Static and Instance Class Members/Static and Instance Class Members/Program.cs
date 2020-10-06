using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_and_Instance_Class_Members
{
    class Program
    {
        //Static names are invoked by the name of the class
        //others are invoked by the instance of the class

        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            float Area = C1.CalculatArea();

            Console.WriteLine("Area = {0}", Area);

            Circle C2 = new Circle(6);
            float Area2 = C2.CalculatArea();

            Console.WriteLine("Area = {0}", Area2);
        }
    }

    class Circle
    {
        static float _PI;
        int _Radius;

        static Circle()
        {
            Console.WriteLine("Static Constructor is the first");
            Circle._PI = 3.1416f;
        }

        public Circle(int Radius)
        {
            Console.WriteLine("Instance Constructor is the second");
            this._Radius = Radius;
        }

        public float CalculatArea()
        {
            return Circle._PI * this._Radius * this._Radius;
        }
    }
}

