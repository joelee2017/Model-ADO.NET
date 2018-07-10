﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model實作與ADO.NET
{
    class Northwind
    {
        private IDataOperation<Customer> _customerOperation = null;
        private IDataOperation<Order> _orderOperation = null;

        public IDataOperation<Customer> Customers
        {
            get
            {
                if (this._customerOperation == null)
                    this._customerOperation = new CustomerDataOperation();

                return this._customerOperation;
            }            
        }

        public IDataOperation<Order> Orders
        {
            get
            {
                if(this._orderOperation == null)
                    this._orderOperation = new  OrderDataOperation();

                return this._orderOperation;
            }
        }
    }
}
