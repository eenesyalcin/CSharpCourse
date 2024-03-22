using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->  LOOPS  <-----");

            ForLoop();
            WhileLoop();
            DoWhileLoop();
            ForEachLoop();

            Console.ReadLine();
        }


        /*
            Burada "for" döngüsünün çalışma mantığı, parantez içerisine sırasıyla başlangıç değeri,
            döngünün şartı ve artış veya azalış değeri yazılır. Şart sağlandığı sürece döngü devam eder. Burada
            "while" döngüsünün aksine artış veya azalış değerinin değiştirilmesi döngü bloklarının içerisinde değil,
            parantez içerisinde en son yazılır.
        */
        private static void ForLoop()
        {
            Console.WriteLine("\n\nFor Loop ---> Printing odd numbers from 1 to 100.");
            Console.WriteLine("__________________________________________________");
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
        }


        /*
            Burada "while" döngüsünün çalışma mantığı, bir şart yazılır ve o şart gerçekleşmeyene kadar "while"
            döngüsünün blokları çalışır. Şartın değiştirilmesi(artış veya azalış değeri) döngüdeki blokların
            içerisinde yapılmalıdır.
        */
        private static void WhileLoop()
        {
            Console.WriteLine("\n\nWhile Loop ---> Printing even numbers from 100 to 0.");
            Console.WriteLine("__________________________________________________");
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number -= 2;
            }
            Console.WriteLine("Now number is = {0}\n", number);
        }


        /*
            Burada "do-while" döngüsünün "While" döngüsünden farkı, eğer "while" döngüsündeki şart çalışmasa
            bile en az 1 defa şartın çalışması için kullanılır.
        */
        private static void DoWhileLoop()
        {
            Console.WriteLine("\n\nDo-While Loop ---> Printing numbers from 9 to back.");
            Console.WriteLine("__________________________________________________");
            int number = 9;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }


        /*
            Burada "forEach" döngü yapısını genellikle dizileri dolaşmak için kullanırız.
            Bir dizideki elemanları sırasıyla tek bir değişkene atarız ve sonrasında o değişkeni ekrana yazdırırız.
        */
        private static void ForEachLoop()
        {
            Console.WriteLine("\n\nForEach Loop ---> Printing numbers starting from 0.");
            Console.WriteLine("__________________________________________________");
            int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}