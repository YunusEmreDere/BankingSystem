﻿using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.BusinessLayer.Abstract
{
    public interface ICustomerService : IGenericService<Customer>
    {
        void TcreateCustomer(string customerTc, string fname, string lname, string password, string phone, string address, string staffTc);
        void TUpdateCustomer(string customerTc, string fname, string lname, string password, string phone, string address, string staffTc);
        void TdeleteCustomer(string customerTc);
        Customer TGetCustomerByTc(string customerTc);
    }
}
