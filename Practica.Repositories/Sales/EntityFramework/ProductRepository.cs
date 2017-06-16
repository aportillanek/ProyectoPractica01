using Practica.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Practica.Repositories.Sales.EntityFramework
{
    public class ProductRepository : RepositoryEF<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }

        public Product SearchByName(string Name)
        {
            return _context.Set<Product>().FirstOrDefault(c => c.Name == Name);
        }
    }
}
