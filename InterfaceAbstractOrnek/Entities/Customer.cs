using InterfaceAbstactOrnek.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstactOrnek.Entities
{
    class Customer:IEntitiy
    {
        
            public int Id { get; set; }
            public string FristName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string NationalityId { get; set; }
        
    }
}
