using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    /*
        PROPERTY
        Özellikleri tutmak için oluşturulan sınıflardır. Burada oluşturulan özellikler genellikle
        veri tabanındaki kolonlara denk gelmektedir. Aşağıda da bir müşterinin bilgilerini tutmak
        için olulturulan bir özellik sınıfı tanımlanmıştır.
    */
    class Customer
    {
        /*
            "get" = Bir değeri ekrana yazdırmak için çağırırken çalışır.
            "set" = Bir özelliğe değer atarken çalışır.
        */
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }



        /*
            ENCAPSULATION
            Eğer bir field üzerinde "get" veya "set" işlemi yaparken başka bir şey daha yapmak istersek
            aşağıda olduğu gibi encapsulation yapmamız gerekir.

            private string _firstName;      ---> Field
            public string FirstName         ---> Property
            {
                get
                {
                    return "Merhaba " + _firstName;
                }
                set
                {
                    _firstName = value;
                }
            }
        */
    }
}