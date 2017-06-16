using Practica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Repositories.Sales
{
    public  interface IEmployeeRepository : IRepository<Employee>
    {
        Employee SearchByLastName(string LastName);
    }
}
