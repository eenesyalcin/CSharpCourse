using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->  MULTIPLE IMPLEMANTATION  <-----\n");


            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }


            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }


            IGetSalary[] getSalaries = new IGetSalary[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var getSalary in getSalaries)
            {
                getSalary.GetSalary();
            }


            Console.ReadLine();
        }
    }



    // SOLID ---> I = Interface Segregation(Arayüz Ayırımı)
    interface IWorker
    {
        void Work();
    }

    interface IGetSalary
    {
        void GetSalary();
    }

    interface IEat
    {
        void Eat();
    }



    // Burada olduğu gibi bir class birden fazla interface'i implemente(uygulamak) edebilir.
    class Manager : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager eats.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager gets a salary.");
        }

        public void Work()
        {
            Console.WriteLine("Manager working.");
        }
    }

    // Burada olduğu gibi bir class birden fazla interface'i implemente(uygulamak) edebilir.
    class Worker : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker eats.\n");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker gets a salary.");
        }

        public void Work()
        {
            Console.WriteLine("Worker working.");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot working.\n");
        }
    }
}