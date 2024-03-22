using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->  APPLICATIONS OF INTERFACES IN REAL LIFE  <-----\n");

            FirstRealLifeApplication();
            SecondRealLifeApplication();

            Console.ReadLine();
        }

        private static void FirstRealLifeApplication()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void SecondRealLifeApplication()
        {
            /*
                POLYMORPHISM
                Polymorphism bir nesneyi farklı amaçlarla implemente(uygulamak) edip, o implementasyonların(uygulama) tamamına
                ya da bir kısmına ulaçmaktır.
            */
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal(),
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }
    }
}