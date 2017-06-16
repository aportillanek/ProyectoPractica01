using Practica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Repositories.Sales
{
      public  interface ICustomerRepository : IRepository<Customer>
    {
        Customer SearchByName(string firtsname);

    }
}
