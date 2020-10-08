using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Why_Properties
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 33;

        public string City { get; set; }
        public string Email { get; set;}

        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Student name can not be null or empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
            }
        }

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student id can not be negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.Id = 100;
            S1.Name = "Oda";
            Console.WriteLine("Id = {0}, Name = {1}, Passmark = {2}",S1.Id, S1.Name, S1.PassMark);
        }
    }
}
