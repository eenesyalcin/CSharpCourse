using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->  VALUE TYPES  <-----");



            /*
                VALUE TYPES
                Değer tipleri aşağıda olduğu gibidir. Değer tutan değişkenler belleğin "stack" kısmında tutulur.
                Bu tür değişkenler sadece değer tutarlar.
            */


            // Aşağıda tanımlana değişken türleri tam sayı değeri vermek için kullanılır.
            byte number1 = 255;                     // 8-bit
            short number2 = 32767;                  // 16-bit
            int number3 = 2147483647;               // 32-bit
            long number4 = 9223372036854775807;     // 64 bit
            // Yukarıda verilen değerler değişken türlerine göre verilebilecek maksimum değerlerdir.
            Console.WriteLine("\nNumber 1 is = {0}", number1);
            Console.WriteLine("Number 2 is = {0}", number2);
            Console.WriteLine("Number 3 is = {0}", number3);
            Console.WriteLine("Number 4 is = {0}", number4);


            // Aşağıda tanımlana "bool" değişken türü sadece "true" ve "false" değerleri alabilir. Genellikle şart bloklarında kullanılır.
            bool condition = false;     // 1-bit
            Console.WriteLine("\nCondition is = {0}", condition);


            // Aşağıda tanımlana "char" değişken türü tek bir karakter için kullanılır.
            char character = 'A';       // 16-bit
            Console.WriteLine("\nCharacter is = {0}", character);
            // Burada "char" değişken türüne verilen değerin sayısal değerini ekrana aşağıdaki gibi yazdırabiliriz.
            Console.WriteLine("Character is = {0}", (int)character);


            // Aşağıda tanımlana değişken türleri ondalıklı sayı değeri vermek için kullanılır.
            double number5 = 10;
            double number6 = 10.4;      // 64-bit
            decimal number7 = 11;
            decimal number8 = 11.4m;    // 128-bit
            /*
                NOT-1: Yukarıdaki değişken türlerinde tam sayı da tanımlanabilir.
                NOT-2: Decimal değişken türünde bir değişken tanımlandığında eğer verilen değer ondalıklı bir değerse
                       sonuna harf olarak "m" ya da "M" koyulur. Eğer tanımlanan sayı tam sayı ise buna ihtiyaç yoktur.
            */
            Console.WriteLine("\nNumber 5 is = {0}", number5);
            Console.WriteLine("Number 6 is = {0}", number6);
            Console.WriteLine("Number 7 is = {0}", number7);
            Console.WriteLine("Number 8 is = {0}", number8);


            // Aşağıda tanımlanan "var" değişken türüne istediğimiz değeri verebiliriz ve verdiğimiz değere göre değişken türü algılanır.
            var number9 = 10;
            Console.WriteLine("\nNumber 9 is = {0}", number9);
            // NOT-3: Bu değişken türüne en başta hangi değer atandıysa değişken tipi o olarak kalır ve değiştirilemez.
            number9 = 'A';
            Console.WriteLine("Number 9 is = {0}", number9);

            // Burada "enum" yapısındaki değeri aşağıdaki gibi ekrana yazdırabiliriz.
            Console.WriteLine("\nFirst day for week = {0}", Days.Monday);
            // Burada "enum" yapısındaki herhangi bir değerin sayısal değerini ekrana aşağıdaki gibi yazdırabiliriz.
            Console.WriteLine("First day for week = {0}", (int)Days.Monday);



            Console.ReadLine();
        }
    }

    /*
        Bu değişken türünü birçok değeri tek bir merkezden yönetmek amacı ile kullanırız.
        Tanımlanan değerleri için verilen bir sayı değeri vardır ve bu default olarak 0'dan başlar.
        Eğer aradaki bir değere sayı değeri verirsek ve ondan sonrakilere vermezsek sonrakilere default olarak sırasıyla sayısal değer verilir.
        NOT-4: Değişken türü "enum" olduğu durumlarda bit sayısı duruma göre değişir.
        NOT-5: Değşken türü "enum" olduğunda global değişken olarak tanımlarız.
    */
    enum Days
    {
        Monday = 10, Tuesday = 20, Wednesday = 30, Thursday, Friday, Saturday, Sunday
    }
}