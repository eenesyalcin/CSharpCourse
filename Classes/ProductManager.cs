using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // Biz class'ları yapmak istediğimiz işleri gruplara ayırmak, gruplar üzerinden işlemleri yapmak ve o gruplara ulaşmak için kullanırız.
    class ProductManager
    {
        // ProductManager class'ı içerisindeki ürün ekleme methodu.
        public void Add()
        {
            Console.WriteLine("Product Adedd!");
        }

        // ProductManager class'ı içerisindeki ürün güncelleme methodu.
        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }
    }
}