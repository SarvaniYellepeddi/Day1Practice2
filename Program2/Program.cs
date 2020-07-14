using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
	class product
	{

		int productId;
		string productName;
		double price;
		string color;

		void Display()
		{
			Console.WriteLine("ID:" + productId + " " + productName + "-" + price + " " + color);
			Console.ReadLine();
		}

        static void Main(string[] args)
		{
			product product1 = new product();
			product1.productId = 121;
			product1.productName = "Hard drive";
			product1.price = 3850;
			product1.color = "Blue";

			product1.Display();
		}
	}
	class ProductMoodel
	{
		static void Main(string[] args)
		{
			product product1 = new product();
			{
				product1.productId = 121;
				product1.productName = "Hard drive";
				product1.price = 3850;
				product1.color = "Blue";
			}
			product1.Display();
		}
	}
}