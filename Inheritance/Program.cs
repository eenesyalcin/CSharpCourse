using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->  INHERITANCE  <-----\n");


            Person[] persons = new Person[3]
            {
                /*
                    Inheritance'ın interface'lerden diğer bir farkı ise tek başına bir anlam ifade etmesidir, kullanılmasıdır.
                    Yani kısacası class'lar tek başına bir anlam ifade eder fakat interface'ler tek başına bir anlam ifade etmezler.
                */
                new Person()
                {
                    FirstName = "Enes"
                },
                new Customer()
                {
                    FirstName = "Sena Betül"
                },
                new Student()
                {
                    FirstName = "Elif"
                }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }


            Console.ReadLine();
        }
    }

    /*
        Inheritance kalıtım anlamına gelmektedir. Inheritance'larda özelliklerin ya da metotların
        özeti değil kendisi yer alamktadır.
    */
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    /*
        Bir sınıf sadece bir tane inheritance alabilir fakat birden fazla interface implemente(uygulamak) yapılabilir.
        Bir sınıfa hem inheritance alıp hem de interface implemente(uygulamak) edilecekse; önce inheritance,
        sonra interface yazılır.
    */
    class Customer : Person     // Person, Customer'ın babasıdır anlamına gelir.
    {
        public string Address { get; set; }
    }

    class Student : Person      // Person, Student'ın babasıdır anlamına gelir.
    {
        public string Department { get; set; }
    }
}