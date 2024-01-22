using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Homework_Interface
{
    internal class Market : IStore
    {
        private Product[] _products = new Product[0];
        public Product[] Products => _products;
        private int _productLimited;
        public int ProductLimit => _productLimited;
        private double _totalIncome;
        public double Totalİncome => _totalIncome;
        public void AddProducts(Product product)
        {
            if (_productLimited < 100)
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = product;
                _productLimited++;
            }
            else 
            { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                                      Limit doludur");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void SellProduct(string name)
        {
            bool check = false;
            for (int i = 0; i < _products.Length; i++)
            {
                check = false;
                if (_products[i].Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                                  Stoktda mehsul qalmayib");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                else if (name == _products[i].Name)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"                                 Satildi :{_products[i].Name}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"                                 Mehsulunu sayi :{_products[i].Count -= 1}");
                    Console.WriteLine($"                                 TotalIncome :{_totalIncome += _products[i].Price}");
                    break;
                }
                else
                {
                    check = true;
                }
            }
            if (check)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                                  Bele meshul yoxdur  ");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void ShowProduct()
        {
            for (int i = 0; i < _products.Length; i++)
            {
                Console.WriteLine($"                                     Name : {_products[i].Name} Price: {_products[i].Price} Count: {_products[i].Count}");
            }
        }
    }
}
