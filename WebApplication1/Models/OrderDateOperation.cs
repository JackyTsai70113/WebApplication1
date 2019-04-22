using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    // 實現OrderDataOperation來處理Order的data
    public class OrderDataOperation : IDataOperation<Order>
    {
        public IEnumerable<Order> Get()
        {
            throw new NotImplementedException();
        }

        public void Create(Order Item)
        {
            throw new NotImplementedException();
        }

        public void Update(Order Item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order Item)
        {
            throw new NotImplementedException();
        }
    }
}