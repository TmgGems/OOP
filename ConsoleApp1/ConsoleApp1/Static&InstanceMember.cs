using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    
    class People
    {
        public string fName;
        public string lName;
        public static string companyName = "ABC";
        public static int fees = 1200000;

        public void getFullName()// instance method vitra dubai static rw instance variable/member access garna sakenxa
        {
            Console.WriteLine("The people full name is {0}",(this.fName + this.lName));
        }

        public static int getFees()// static method only access static variables
        {
            return fees;
        }
        
        public static int getAnnualIncrementFees()
        {
            return fees / 10;
        }

        public static int getScholarshipFees(int price)
        {
            return price / 2;
        }
    }
    internal class Class1
    {
        static void Main(string[] args)
        {
            People p1 = new People();
            p1.fName = "Ghhyamjo";
            p1.lName = "Lama";
            p1.getFullName();
            Console.WriteLine(People.companyName);
            Console.WriteLine(People.getFees());
            Console.WriteLine(People.getAnnualIncrementFees());
            Console.WriteLine(People.getScholarshipFees(1200000));
        }
    }
}
