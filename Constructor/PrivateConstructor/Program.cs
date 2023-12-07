using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructor
{
    /* 
     ➤ One use of a private constructor is when we have only static members.
     > Orice we provide a constructor that is either private or public or any, the compiler will not add the parameter-less public
    constructor to the class.
    > In the presence of parameterless private constructor you cannot create a default constructor.
    > We cannot inherit the class in which we have a private
    constructor.
    > We can have parameters in private constructor.
     */

    class Student
    {
        public static int a;

        private Student()
        {

        }

        public static void getTime()
        {
            Console.WriteLine(DateTime.Now);
        }

        public static int getIncrement()
        {
            return ++a;
        }
    }

    /*
    class S : Student// Private constructor ko class bata inherit garna paudaina
    {
    }
    */

    internal class Program
    {
        static void Main(string[] args)
        {
         //Student s1 = new Student();// not possible to create an instance of this class

            Student.getTime();
            Student.a = 20;
            Console.WriteLine(Student.getIncrement());  
        }
    }
}
