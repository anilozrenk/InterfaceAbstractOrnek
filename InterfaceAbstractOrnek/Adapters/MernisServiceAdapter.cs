using InterfaceAbstactOrnek.Abstract;
using InterfaceAbstactOrnek.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstactOrnek.Adapters
{
    class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(customer.NationalityId), customer.FristName, customer.LastName, customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
                
        }
    }
}
