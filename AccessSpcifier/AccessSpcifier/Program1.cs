using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpcifier
{
    public class people
    {
        public string pName;
        public int pAge;

        public people()
        {
            this.pName = "Gems Tmg";
            this.pAge = 16;
        }
        public void getInfo()
        {
            Console.WriteLine("Person Name : {0}",this.pName);
            Console.WriteLine("Person Age : {0}", this.pAge);
        }
    }
    internal class Program1
    {
        static void Main(string[] args)
        {
            people p = new people();
            p.getInfo();
        }
    }
}
