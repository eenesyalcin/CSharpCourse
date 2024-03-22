using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->  CONDITIONALS  <-----");



            // "IF-ELSE" ŞART BLOKLARI
            var number1 = 11;
            if (number1 == 10)  // Burada "if" içerisine bir şart yazılır ve doğru olduğunda o bloğa girer.
            {
                Console.WriteLine("\nNumber is 10.");
            }
            else if (number1 == 20) // Burada "else if" içerisine bir şart yazılır ve doğru olduğunda o bloğa girer.
            {
                Console.WriteLine("\nNumber is 20.");
            }
            else    // Burada "else" içerisine hiçbir şart sağlanmadığında girer.
            {
                Console.WriteLine("\nNumber is not 10 or 20.");
            }
            // NOT-1: Buradaki şart bloklarında "if" ve "else if" bloklarının default değeri "true" olarak çalışır.


            // Bir "if-else" şart bloğunu aşağıdaki gibi single line olarak da oluşturabiliriz.
            Console.WriteLine(number1 == 10 ? "\nNumber is 10." : "\nNumber is not 10.");



            // "SWITCH-CASE" YAPISI
            var number2 = 30;
            switch (number2)    // Burada "switch" içerisine bir değer değişkeni yazılır.
            {
                case 30:        // Değer değişkeninin değerine göre "case" yapılarından biri çalışır.
                    Console.WriteLine("\nNumber is 30.");
                    break;
                case 40:
                    Console.WriteLine("\nNumber is 40.");
                    break;
                default:        // Eğer "case" yapılarından herhangi biri çalışmazsa "default" yapısı çalışır.
                    Console.WriteLine("\nNumber is not 30 or 40.");
                    break;
            }
            // NOT-2: Burdaki yapıda her yapı "break" komutu ile sonlandırılmalıdır. Bu o yapının işini yaptıktna sonra kırıldığı anlamına gelir.



            // Örnek-1
            var number3 = 11;
            if (number3 >= 0 && number3 <= 100)
            {
                Console.WriteLine("\nNumber is between 0-100.");
            }
            else if (number3 >= 100 && number3 <= 200)
            {
                Console.WriteLine("\nNumber is between 101-200.");
            }
            else if (number3 < 0 || number3 > 200)
            {
                Console.WriteLine("\nNumber is less than 0 or greater than 200.");
            }



            // Aşağıda "if-else" şarrt bloklarının iç içe kullanımı gösterilmiştir.
            var number4 = 11;
            if (number4 < 100)
            {
                if (number4 > 80 && number4 < 90)
                {
                    Console.WriteLine("\nNumber is less than 90 or greater than 80.");
                }
                else if (number4 > 70 && number4 <= 80)
                {
                    Console.WriteLine("\nNumber is less(equal) than 80 or greater than 70.");
                }
                else
                {
                    Console.WriteLine("\nNumber is less(equal) than 70.");
                }
            }
            else
            {
                Console.WriteLine("\nNumber is greater than 100.");
            }



            Console.ReadLine();
        }
    }
}