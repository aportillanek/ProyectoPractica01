using Practica.Repositories.Sales;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }
        IEmployeeRepository Employees { get; }
        IProductRepository Products { get; }
    }
}
