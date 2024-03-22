using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_2
{
    interface ICustomerDal
    {
        void Add();
        void Delete();
        void Update();
    }

    // ICustomerDal, SqlServerCustomerDal biçiminde implemente(uygulamak) edildi. Bu bir polymorphism örneğidir.
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("\nSQL Added!");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("SQL Updated!");
        }
    }

    // ICustomerDal, OracleCustomerDal biçiminde implemente(uygulamak) edildi. Bu bir polymorphism örneğidir.
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated!");
        }
    }

    // ICustomerDal, MySqlCustomerDal biçiminde implemente(uygulamak) edildi. Bu bir polymorphism örneğidir.
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySQL Added!");
        }

        public void Delete()
        {
            Console.WriteLine("MySQL Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("MySQL Updated!");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}