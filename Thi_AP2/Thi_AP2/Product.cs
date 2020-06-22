using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_PhamThanhTung
{
    abstract class Product
    {
        protected int ID;
        protected string name;
        protected double price;
        protected string producer;
        public Product(int ID, string name, double price, string producer)
        {
            this.ID = ID;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }
        public abstract double computeTax();
    }
}
