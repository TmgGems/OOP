using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessSpcifier;

class Student : people
{

}


namespace AccessSpecifier2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.getInfo();
        }
    }
}
