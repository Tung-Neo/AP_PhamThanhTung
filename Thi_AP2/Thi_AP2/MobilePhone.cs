using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_PhamThanhTung
{
    class MobilePhone : Product
    {
        public MobilePhone(int ID, string name, double price, string producer) : base(ID, name, price, producer) { }
        public override double computeTax()
        {
            return price * 10 / 100;
        }
    }
}
