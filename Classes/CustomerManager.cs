using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // Biz class'ları yapmak istediğimiz işleri gruplara ayırmak, gruplar üzerinden işlemleri yapmak ve o gruplara ulaşmak için kullanırız.
    class CustomerManager
    {
        // CustomerManager class'ı içerisindeki müşteri ekleme methodu.
        public void Add()
        {
            Console.WriteLine("Customer Adedd!");
        }

        // CustomerManager class'ı içerisindeki müşteri güncelleme methodu.
        public void Update()
        {
            Console.WriteLine("Customer Updated!\n");
        }
    }
}