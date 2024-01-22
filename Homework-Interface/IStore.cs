using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Interface
{
    internal interface IStore
    {
        public Product[] Products { get;}
        public int ProductLimit { get; }
        public double Totalİncome { get;}
        public void AddProducts(Product product);
        public void SellProduct(string name);
    }
}
