using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->  METHODS  <-----\n");


            /*
                Metodları bir işi birden fazla yaptığımızda ayrı ayrı yazmak yerine bir defa yazıp sonrasında her yerde
                kullanabilmek için ve böylece programı daha dinamik hale getirmek için kullanırız. 
            */
            Add1();
            Add1();
            Add1();

            var result1 = Add2(20, 30);
            Console.WriteLine("\n" + result1);

            var result2 = Add3(20);
            Console.WriteLine("\n" + result2);

            int firstNum1 = 20;
            int secondNum1 = 100;
            // NOT-1: Eğer "ref" komutu ile parametre gönderilirse "ref" komutu metod hem tanımlanırken hem de kullanılırken yazılmalıdır.
            var result3 = Add4(ref firstNum1, secondNum1);
            Console.WriteLine("\n" + result3);
            Console.WriteLine(firstNum1);

            int firstNum2;
            int secondNum2 = 100;
            // NOT-2: Eğer "out" komutu ile parametre gönderilirse "out" komutu metod hem tanımlanırken hem de kullanılırken yazılmalıdır.
            var result4 = Add5(out firstNum2, secondNum2);
            Console.WriteLine("\n" + result4);
            Console.WriteLine(firstNum2);

            Console.WriteLine("\n" + Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 8));

            Console.WriteLine("\n" + Add6(1, 2, 3, 4, 5));


            Console.ReadLine();
        }


        // Aşağıda parametresiz metod tanımlanmıştır. Parametresiz metod bir değer döndürmediği için metodun tipi "void" olur.
        static void Add1()
        {
            Console.WriteLine("Added!");
        }


        /*
            Aşağda iki tane sayıyı parametre olarak alan metod tanımlanmıştır.
            Parametre alan metodlar geriye bir değer döndürür ve döndüreceği değerin tipi neyse metod o tipte tanımlanır.
        */
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }


        // Metodlara parametre verirken aşağıdaki gibi default değer veririz ve default değer verdiğimiz parametreler en sona yazılır.
        static int Add3(int num1, int num2 = 30)
        {
            var result = num1 + num2;
            return result;
        }


        /*
            Burada "ref" komutu gönderilen parametrenin referans tip gibi gönderilmesini sağlar. Yani tanımlanan değişkenin değeri
            metod içerisinde değişmişse ilk tanımlandığı değer de değişir.
        */
        static int Add4(ref int firstNum1, int secondNum1)
        {
            firstNum1 = 30;
            var result = firstNum1 + secondNum1;
            return result;
        }


        /*
            Burada "out" komutu "ref" komutu ile aynı görevi görür. "ref" komutundan farkı ise değişken tanımlandığında
            ilk değerin atanma zorunluluğunun olmamasıdır.
        */
        static int Add5(out int firstNum2, int secondNum2)
        {
            firstNum2 = 30;
            var result = firstNum2 + secondNum2;
            return result;
        }


        // Aşağıda olduğu gibi ismi aynı olan, farklı fakat benzer işler gören metod tanımlanabilir.
        static int Multiply(int firstNum3, int secondNum3)
        {
            return firstNum3 * secondNum3;
        }

        static int Multiply(int firstNum3, int secondNum3, int thirdNum3)
        {
            return firstNum3 * secondNum3 * thirdNum3;
        }


        /*
            Aşağıda olduğu gibi bir metoudu "params" komutu ile "ovrloading" yapabiliriz.
            Bunun amacı metoda dizi şeklinde çok veri göndermek ve o veriler ile toplu işlem yapabilmektir.
        */
        static int Add6(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}