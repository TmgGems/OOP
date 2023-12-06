using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ConstructorOverloading
    {
        public ConstructorOverloading() 
        {
            Console.WriteLine("This is the first Constructor .");
        }
        public ConstructorOverloading(int a , int b)
        {
            Console.WriteLine("This is the second Constructor{0} .",(a+b));
        }
       public ConstructorOverloading(int a , int b, int c)
        {
            Console.WriteLine("This is the third Constructor{0}" .,(a+b+c));
        }

        public ConstructorOverloading(string a, string b, string c)
        {
            Console.WriteLine("This is the fourth constructor {0} .",(a + b + c));
        }

        static void Main(string[] args)
        {
            ConstructorOverloading c = new ConstructorOverloading(1,2,3);
        }
    }
}
