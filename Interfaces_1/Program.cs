using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroductionInterfaces();

            Console.ReadLine();
        }

        private static void IntroductionInterfaces()
        {
            Console.WriteLine("----->  INTRODUCTION TO INTERFACES  <-----\n");

            PersonManager personManager = new PersonManager();

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Enes",
                LastName = "YALÇIN",
                Address = "Kastamonu"
            };

            Student student = new Student
            {
                Id = 2,
                FirstName = "Sena Betül",
                LastName = "YAZICIOĞLU",
                Department = "Computer Engineering"
            };

            Worker worker = new Worker
            {
                Id = 3,
                FirstName = "Elif",
                LastName = "YALÇIN",
                Job = "Forest Engineer"
            };

            // Burada artık customer, student ve worker için ortak olan özelliklere erişebiliriz.
            personManager.Add(customer);
            personManager.Add(student);
            personManager.Add(worker);
        }
    }



    /*
        Interface'lerin en büyük kullanım amacı temel nesne veya operasyon oluşturup,
        tüm nesne veya operasyonları ondan implement(uygulamak) etmektir.
        Interface'lerde isimlendirme yapılırken başına "I" harfi yazılır ve sonrasında PascalCase
        yöntemi ile isimlendirme yapılır. Yazılan "I" harfi interface olduğu anlamına gelir.
        Interface'lerin tek başına bir kullanımı yoktur. O yüzden "new" yapılarak kullanıma açılamaz.
    */
    interface IPerson
    {
        // Interface içerisine sadece ortak olan özellik veya metotların, sadece imzası yazılır.
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }



    // Interface içerisinde tanımlanan özellik veya metodları, yani imazaları class içerisinde tanımlamamız gerekir.
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Burada olduğu gibi sadece customer'a ait olan özelliği de eklyebiliriz.
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Burada olduğu gibi sadece student'a ait olan özelliği de eklyebiliriz.
        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Burada olduğu gibi sadece student'a ait olan özelliği de eklyebiliriz.
        public string Job { get; set; }
    }

    class PersonManager
    {
        /*
            Burada parametre olarak interface'i parametre olarak gönderdiğimiz için ortak olan,
            yani interface içerisinde imza olarak tanımladığımız özelliklere tüm kullanıcılar için ulaşabiliriz.
        */
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName + " Added!");
        }
    }
}