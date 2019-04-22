using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    // 實現CustomerDataOperation來處理Customer的data
    public class CustomerDataOperation : IDataOperation<Customer>
    {
        private string _path = Environment.CurrentDirectory;
        private string _connectionString =
            @"Server=(localdb)\v11.0;
                Integrated Security=true
                AttachDbFileName=" +
                Environment.CurrentDirectory +
                @"\Northwind.mdf";
        public IEnumerable<Customer> Get()
        {
            throw new NotImplementedException();
        }

        public void Create(Customer Item)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer Item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer Item)
        {
            throw new NotImplementedException();
        }
    }
}