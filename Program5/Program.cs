using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
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
    class ProductMoodel
    {
        private static Product product1;

        static void Main(string[] args)
        {
            product1 = new Product();
            {
                int productId = 121;
                string productName = "Hard drive";
                int price = 3850;
                string color = "Blue";
            };

            product1.Display();
            Product product2 = new Product(123, "Pendrive", 450, "red");
            product2.Display();
            product1 = new Product(124, "SDcard", 300, "black");
            product1.Display();
        }
    }
}
