using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    /*
     STATIC CLASS IN C#
→ Classes that cannot be instantiated or inherited are known as static classes and the static keyword is used before the class name that consists of static data members and static methods. ▸
→ It is not possible to create an instance of a static class using the new keyword. The main features of static classes are as follows: o They can only contain static members.
They cannot be instantiated or inherited and cannot contain instance constructors. However, the developer can create static constructors to initialize the static members. 
     */

    static class product
    {
        public static string productName;
        public static int productId;
        public static int productPrice;

        static product()
        {
            productName = "Huwaii";
            productId = 1;
            productPrice = 1000000;
        }

        public static void getInfo()
        {
            Console.WriteLine("Product Name : {0}",productName);
            Console.WriteLine("Product Id :{0}",productId);
            Console.WriteLine("Product Price : {0}",productPrice);
        }

        public static void getDiscount()
        {
            int discountAmount = productPrice / 10;
            Console.WriteLine("Discount amount :", discountAmount);
            Console.WriteLine("Total Cost :{0}", (productPrice - discountAmount));
        }


    }

    /*
    class Purchase:product//cannot derive from static class
    {

    }
    */
    internal class Program
    {
        static void Main(string[] args)
        {
           // product p = new product();//cannot create an instance of an static class

             product.getInfo();
            product.getDiscount();
        }
    }
}
