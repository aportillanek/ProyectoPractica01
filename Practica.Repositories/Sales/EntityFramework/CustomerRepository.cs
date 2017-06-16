using Microsoft.EntityFrameworkCore;
using Practica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica.Repositories.Sales.EntityFramework
{
    public class CustomerRepository : RepositoryEF<Customer>, ICustomerRepository
    {

        public CustomerRepository(DbContext context) : base(context)
        {

        }

        public Customer SearchByName(string firtsname)
        {
            return _context.Set<Customer>().FirstOrDefault(c => c.FirstName == firtsname );
        }
    }
}
