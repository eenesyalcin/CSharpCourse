using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->  CLASSES  <-----\n");



            // Aşağıdaki gibi bir class'ı kullanmak için onun bir örneğini oluşturmamız gerekir.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            /*
                NOT-1: Bir class'ın ismi oluştrulurken PascalCase isimlenddirme kuralı uygulanır..
                       Yani her kelimenin ilk harfi büyük harfle başlar.
                NOT-2: Bir class'ın örneği oluşturulurken camelCase isimlendirme kuralı uygulanır.
                       Yani oluşturulan isimdeki ilk kelimenin ilk harfi küçük sonrakiler büyük yazılır.
            */
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();



            /*
                Aşağıda olduğu gibi örnek oluşturduktan sonra property sınıfında tanımladığımız özellikleri
                aşağıda müşteri için oluşturabiliriz. İki farklı şekilde müşteri için özellikleri oluşturabiliriz.
            */
            // OLUŞTURMA ŞEKLİ-1
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Enes";
            customer1.LastName = "YALÇIN";
            customer1.City = "Karabük";

            // OLUŞTURMA ŞEKLİ-2
            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Sena Betül",
                LastName = "YAZICIOĞLU",
                City = "İstanbul"
            };



            Console.ReadLine();
        }
    }
}