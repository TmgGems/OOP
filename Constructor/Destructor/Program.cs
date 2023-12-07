using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    /* 
     DESTRUCTORS IN C# PROGRAMMING
A destructor is a special method which has the same name as the class but starts with the character ~ before the class name and immediately de-allocates memory of objects that are no longer required.
Following are the features of destructors:
• Destructors cannot be overloaded or inherited.
• Destructors cannot be explicitly invoked.
• Destructors cannot specify access modifiers and cannot take
parameters. 
     */

    class Person
    {
        public string name;
        public int age;

        public Person(string name , int age)
        {
            this.name = name;   
            this.age = age;
        }

        public string getName()
        {
            return this.name;
        }

        public int getAge()
        {
            return this.age;
        }
        ~Person()
        {
            Console.WriteLine("Destructor Invoked");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Gems", 16);
            Console.WriteLine(p1.getName());
            Console.WriteLine(p1.getAge());

            Console.WriteLine("------------------");
            Person p2 = new Person("Gaurab", 27);
            Console.WriteLine(p2.getName());
            Console.WriteLine(p2.getAge());

        }
    }
}
