using InterfaceAbstactOrnek.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace InterfaceAbstactOrnek.Abstract
{
    class CustomerCheckService : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {

            return true;
        }
    }
}
