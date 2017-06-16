using Microsoft.EntityFrameworkCore;
using Practica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica.Repositories.Sales.EntityFramework
{
    public class EmployeeRepository : RepositoryEF<Employee>, IEmployeeRepository
    {

        public EmployeeRepository(DbContext context) : base(context)
        {

        }


        public Employee  SearchByLastName(string LastName)
        {
            return _context.Set<Employee>().FirstOrDefault(c => c.LastName == LastName);
        }
    }
}
