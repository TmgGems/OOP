using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyConstructor
{
    /* 
     Copy Constructor creates an object by copying variables from another object
     Purpose is to initialize a new instance to the values of an existing instance.
     Copies a data of one object into another object
     It is a parameterized constructor which contains a parameter of same class type.
     */

    class Example
    {
        string name;
        int age;

        public Example(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Example(Example e)//Copy Constructor
        {
            this.name=e.name;
            this.age = e.age;
        }

        public void getData()
        {
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Age : {0}", age);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Example obj1 = new Example( "Gems Tmg", 16);
            obj1.getData(); 
            Example obj2 = new Example(obj1);
            obj2.getData();
            
        }
    }
}
