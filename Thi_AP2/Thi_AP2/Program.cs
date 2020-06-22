using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_PhamThanhTung
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum;
            Book book1 = new Book(1, "Book 1", 11.2, "I");
            Book book2 = new Book(2, "Book 2", 9.4, "LOVE");
            Book book3 = new Book(3, "Book 3", 12.5, "YOU");
            MobilePhone mb1 = new MobilePhone(4, "Redmi Note 8", 100.5, "Xiaomi");
            MobilePhone mb2 = new MobilePhone(5, "Realme 6", 200.5, "Realme");
            MobilePhone mb3 = new MobilePhone(5, "Iphone 11", 300.5, "Iphone");
            List<Product> product = new List<Product>();
            product.Add(book1);
            product.Add(book2);
            product.Add(book3);
            product.Add(mb1);
            product.Add(mb2);
            product.Add(mb3);
            sum = book1.computeTax() + book2.computeTax() + book3.computeTax() + mb1.computeTax() + mb2.computeTax() + mb3.computeTax();
            Console.WriteLine("The sum tax is: {0}", sum);
            Console.ReadLine();
        }
    }
}
