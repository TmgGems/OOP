using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    /* 
     **********STATIC CONSTRUCTOR*****************
     -> A static constructor is used to initialize static varibales of the class and to perform a particular action only once.
     -> Static constructor is called only once , no matter how many objects you create.
     -> Static constructor is called before instance(default or parameterized) constructor.
     -> A static constructor does not take any parameters and does not use any access modifiers.
     -> Only one static constructor can be created in the class.
     -> It is called automatically  before the first instance of the class created.
     -> We cannot call static constructor directly.ClR(Common Language Runtime->controls program execution)
     
    */
    class person
    {
        public static string personName;
        public static int personAge;

        static person()
        {
            personName = "Gems";
            personAge = 16;
            Console.WriteLine("Static Constructor Created .");
        }

        public person()
        {
            Console.WriteLine("Default Constructor Created !");
        }


        public void getDetails()
        {
            Console.WriteLine("Person name is {0} ", personName);
            Console.WriteLine("Person age is {0}", personAge);
        }
            
    }
    internal class StaticConstructor
    {
        static void Main(string[] args)
        {
            person p = new person();
            person s = new person();
        }
    }
}
