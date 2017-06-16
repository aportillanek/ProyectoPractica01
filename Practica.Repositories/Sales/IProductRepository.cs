using Practica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Repositories.Sales
{
     public interface IProductRepository : IRepository<Product>
    {
        Product SearchByName(string Name);
    }
}
