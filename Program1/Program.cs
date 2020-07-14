using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Product
    {
        internal int productId;
        internal string productName;
        internal double price;
        internal string color;

        internal void Display()
        {
            Console.WriteLine("ID:" + productId + " " + productName + "-" + price + " " + color);
        }
    }
    class ProductModel
    {

        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productId = 248;
            product1.productName = "Pendrive";
            product1.price = 850;
            product1.color = "Black";

            product1.Display();
        }
    }
}
