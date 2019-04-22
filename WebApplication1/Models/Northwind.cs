using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    // 原先需要關心所有資料的讀寫細節, 
    // 現在只要關心CustomerDataOperation class 及OrderDataOperation的生成即可
    // 至於實際的資料讀寫, 可以交給各自的class去搞定即可
    public class Northwind
    {
        private IDataOperation<Customer> _customerOperation = null;
        private IDataOperation<Order> _orderOperation = null;

        public IDataOperation<Customer> Customers
        {
            get
            {
                if (_customerOperation == null)
                    _customerOperation = new CustomerDataOperation();

                return this._customerOperation;
            }
        }

        public IDataOperation<Order> Orders
        {
            get
            {
                if (_orderOperation == null)
                    _orderOperation = new OrderDataOperation();

                return this._orderOperation;
            }
        }
    }
}