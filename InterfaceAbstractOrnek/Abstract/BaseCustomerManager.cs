using InterfaceAbstactOrnek.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstactOrnek.Abstract
{
    abstract class  BaseCustomerManager : ICustumerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine(customer.FristName+ " db e kaydedili");        }
    }
}
