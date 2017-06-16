using Microsoft.EntityFrameworkCore;
using Practica.Repositories.Sales;
using Practica.Repositories.Sales.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.UnitOfWork
{
     public class EFUnitOfWork: IUnitOfWork
    {
        public EFUnitOfWork(DbContext context)
        {
            Customers = new CustomerRepository(context);
            Employees = new EmployeeRepository(context);
            Products = new ProductRepository(context);
            //Orders = new RepositoryEF<Order>(context);
            //OrderItems = new RepositoryEF<OrderItem>(context);
            //Products = new RepositoryEF<Product>(context);
            //Suppliers = new RepositoryEF<Supplier>(context);
        }

        public ICustomerRepository Customers { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public IProductRepository Products { get; private set; }
        //public IRepository<OrderItem> OrderItems { get; private set; }
        //public IRepository<Product> Products { get; private set; }
        //public IRepository<Supplier> Suppliers { get; private set; }
    }
}
