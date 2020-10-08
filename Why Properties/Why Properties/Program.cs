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

        public int GetPassMark()
        {
            return this._passMark;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Student name can not be null or empty");
            }
            this._name = Name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
        }

        public void SetId(int id)
        {
            if(id <= 0)
            {
                throw new Exception("Student id can not be negative");
            }
            this._id = id;
        }

        public int GetId()
        {
            return this._id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.SetId(10);
            S1.SetName("Oda");

            Console.WriteLine("Id = {0}", S1.GetId());
            Console.WriteLine("Name = {0}", S1.GetName());
            Console.WriteLine("Passmark = {0}", S1.GetPassMark());
        }
    }
}
