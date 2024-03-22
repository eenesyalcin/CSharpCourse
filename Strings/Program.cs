using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->  STRINGS  <-----\n\n");

            IntroductionStrings();
            Console.WriteLine("--------------------------------------------------------------------------------");
            StringMethods();

            Console.ReadLine();
        }

        private static void IntroductionStrings()
        {
            Console.WriteLine("Introduction to Strings");
            Console.WriteLine("_________________________");
            string city1 = "Ankara";
            Console.WriteLine(city1);                   // Burada string değeri ekrana yazdırıyoruz.
            Console.WriteLine("\n" + city1[0] + "\n");  // Burada string değerin 1. karakterini(index=0) ekrana yazdırıyoruz.

            // Burada string ifadenin tüm karakterlerini döngü ile alt alta ekrana yazdırıyoruz.
            foreach (var item in city1)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            // Burada olduğu gibi stringlerde toplama işlemi yapabiliyoruz.
            string result = city1 + " " + city2;
            Console.WriteLine("\n" + result);
            // Burada stringlerde toplama işleminin alternatifi olan string formatta, stringleri birleştirme işlemi yapıyoruz.
            Console.WriteLine(String.Format("{0} {1}", city1, city2));
        }

        private static void StringMethods()
        {
            Console.WriteLine("\nString Methods");
            Console.WriteLine("_________________________");


            // Burada cümleyi string bir değişken olarak tanımlıyoruz.
            string sentence = "My name is Enes YALÇIN";


            // Burada string ifadenin karakter uzunluğunu buluyoruz.
            var result1 = sentence.Length;
            Console.WriteLine(result1);


            // Burada string ifadeyi klonluyoruz ve cümleyi değiştirdiğimizde
            var result2 = sentence.Clone();
            sentence = "My name is Sena Betül YAZICIOĞLU";
            Console.WriteLine("\n" + sentence);


            // Burada son karakter veya karakterlerin değerini sorguluyoruz.
            bool result3 = sentence.EndsWith("N");  // False
            Console.WriteLine("\n" + result3);


            // Burada ilk karakter veya karakterlerin değerini sorguluyoruz. 
            bool result4 = sentence.StartsWith("My name");  // True
            Console.WriteLine("\n" + result4);


            // Burada bir karakter veya karakterlerin kaçıncı indexten başladığını bulmak için string ifadeyi baştan taratıyoruz.
            var result5 = sentence.IndexOf("name");
            Console.WriteLine("\n" + result5);
            // NOT-1: Boşlukta bir karakter değeridir.
            var result6 = sentence.IndexOf(" ");
            Console.WriteLine(result6);


            // Burada bir karakter veya karakterlerin kaçıncı indexten başladığını bulmak için string ifadeyi sondan taratıyoruz.
            var result7 = sentence.LastIndexOf("Z");
            Console.WriteLine("\n" + result7);


            // Burada string ifadeye önce kaçıncı indexten itibaren olduğunu belirtip, sonra karakter veya karakterler ekliyoruz.
            var result8 = sentence.Insert(0, "Hello, ");
            Console.WriteLine("\n" + result8);


            // Burada başlangıç için bir index numarası belirtip, o indexten sonraki karakterleri alabiliyoruz. 
            var result9 = sentence.Substring(3);
            Console.WriteLine("\n" + result9);
            // NOT-2: Bu metodu başlangıç için index numarası verdikten sonra, almak istediğimiz karakter sayısını vererek de kullanabiliriz.
            var result10 = sentence.Substring(3, 4);
            Console.WriteLine(result10);


            // Burada tüm karakterleri küçük harfe çeviriyoruz.
            var result11 = sentence.ToLower();
            Console.WriteLine("\n" + result11);


            // Burada tüm karakterleri büyük harfe çeviriyoruz.
            var result12 = sentence.ToUpper();
            Console.WriteLine("\n" + result12);


            // Burada önce değiştirilecek karakteri, sonra değiştirilen karakter yerine gelecek karakteri belirtip karakterleri değiştiriyoruz.
            var result13 = sentence.Replace(",", "-");
            Console.WriteLine("\n" + result13);


            // Burada bir başlangıç için bir index numarası belirtip, o indexten sonraki karakterleri silebiliyoruz.
            var result14 = sentence.Remove(3);
            Console.WriteLine("\n" + result14);
            // NOT-3: Bu metodu başlangıç için index numarası verdikten sonra, silmek istediğimiz karakter sayısını vererek de kullanabiliriz.
            var result15 = sentence.Remove(2, 5);
            Console.WriteLine(result15);
        }
    }
}