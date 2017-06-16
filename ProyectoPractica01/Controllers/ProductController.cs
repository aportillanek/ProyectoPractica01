using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practica.UnitOfWork;

namespace ProyectoPractica01.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unit;
        public ProductController(IUnitOfWork unit)
        {
            _unit = unit;
        }
        public IActionResult Index()
        {
           return View(_unit.Products.GetAll());
        }

        public IActionResult Detail()
        {


            return View(_unit.Products.SearchByName("Adjustable Race"));
        }
    }
}