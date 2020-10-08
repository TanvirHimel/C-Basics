using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_in_c_sharp
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Customer Id = {0}, Name = {1}", this._id, this._name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer C = new Customer(20, "ABC");
            C.PrintDetails();

            Customer C2 = new Customer();
            C2.Name = "XYZ";
            C2.Id = 21;
            C2.PrintDetails();

            Customer C3 = new Customer
            {
                Id = 12,
                Name = "PQR"
            };
            C3.PrintDetails();
        }
    }
}
