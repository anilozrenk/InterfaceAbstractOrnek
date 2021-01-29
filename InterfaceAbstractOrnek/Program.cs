using System;
using InterfaceAbstactOrnek.Abstract;
using InterfaceAbstactOrnek.Adapters;
using InterfaceAbstactOrnek.Concrete;
using InterfaceAbstactOrnek.Entities;


namespace InterfaceAbstractOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1999, 6, 22),
                FristName = "Anıl",
                LastName = "Özrenk",
                NationalityId = "12345678910"
            });


        }

    }
}
