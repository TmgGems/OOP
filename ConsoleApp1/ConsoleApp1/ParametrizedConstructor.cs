using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        /*
         //Default Constructor
        public Employee()
        {
            Console.WriteLine("Our Employees ");
        }
        */
        int empId;
        string empName;

        public Employee(int empId, string empName)
        {
            this.empId = empId;
            this.empName = empName;
        }

        public int  emID()
        {
            return this.empId;
        }

        public string emName()
        {
            return this.empName;
        }

        static void Main(string[] args)
        {
            // Employee emp = new Employee();  -> Default Constructor calling
            Employee emp1 = new Employee(16, "Ghhyamjo");
            Console.WriteLine("Employee id is {0}",emp1.emID());
            Console.WriteLine("Employee name is {0}",emp1.emName());
            Console.WriteLine("-----------------------------");
            Employee emp2 = new Employee(27, "Gems");
            Console.WriteLine("Employee id is {0}", emp2.emID());
            Console.WriteLine("Employee name is {0}", emp2.emName());
        }
    }
}
