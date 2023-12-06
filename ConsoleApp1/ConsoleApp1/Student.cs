using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        int rollNo;
        string name;
        string address;

        public void setInfo(int rollNo,string name,string address)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.address = address;
        }

        public void getInfo()
        {
            Console.WriteLine("Your name is {0} from {1} and your roll no is {2} ",name,address,rollNo);
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter the info of {i+1} student .");
                Console.WriteLine("---------------------------------");
                Student s = new Student();
                Console.WriteLine("Enter the name of a student :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the roll no of student .");
                int roll = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the address of a student .");
                string address = Console.ReadLine();
                s.setInfo(roll, name, address);
                s.getInfo();
            }
           
        }
    }
}
