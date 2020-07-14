using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
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
        internal Product()
        {
            Console.WriteLine("Empty Object Initialization");
        }
        internal Product(int productId, string productName, double price, string color)
        {
            Console.WriteLine("Object Initialized");
            this.productId = productId;
            this.productName = productName;
            this.color = color;
            this.price = price;

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
            Product product2 = new Product(369, "Mobile", 5000, "Silver");
            product2.Display();
        }
    }
}