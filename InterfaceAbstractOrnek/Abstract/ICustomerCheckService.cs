using InterfaceAbstactOrnek.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstactOrnek.Abstract
{
    interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
