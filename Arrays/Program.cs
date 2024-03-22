using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->  ARRAYS  <-----\n\n");



            /*
                Diziler aynı veri tipindeki birden fazla değeri tutmaya yarayan yapılardır.
                Diziler aşağıdaki gibi 4 farklı durumda tanımlanabilirler.
            */

            // DURUM-1
            string[] students1 = new string[3];
            students1[0] = "Enes";
            students1[1] = "Sena Betül";
            students1[2] = "Elif";

            // DURUM-2
            string[] students2 = new string[3] { "Enes", "Sena Betül", "Elif" };

            // DURUM-3
            string[] students3 = new[] { "Enes", "Sena Betül", "Elif" };

            // DURUM-4
            string[] students4 = { "Enes", "Sena Betül", "Elif" };

            // Dizi elemanlarının ekrana yazdırılması
            foreach (var student in students1)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("\n");



            /*
                Çok boyutlu diziler aşağıdaki gibi tanımlanabilirler.
                Aşağıda 7 satır ve 3 kolondan oluşan bir dizi yapısı tanımlanmıştır.
            */
            string[,] citiesByRegion = new string[7, 3]
            {
                {"İstanbul","Bursa","Yalova" },
                {"Adana","Hatay","Osmaniye" },
                {"İzmir","Aydın","Muğla" },
                {"Gaziantep","Kilis","Adıyaman" },
                {"Eskişehir","Konya","Ankara" },
                {"Bolu","Kastamonu","Sinop" },
                {"Antalya","Burdur","Isparta" }
            };

            // Çok boyutlu dizilerin ekrana yazdırılması.
            for (int i = 0; i <= citiesByRegion.GetUpperBound(0); i++)
            {
                Console.WriteLine("__________");
                for (int j = 0; j <= citiesByRegion.GetUpperBound(1); j++)
                {
                    Console.WriteLine(citiesByRegion[i, j]);
                }
            }



            Console.ReadLine();
        }
    }
}