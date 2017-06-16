using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practica.UnitOfWork;
using Practica.Models;

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
      
        public IActionResult Edit(int id)
        {
            
            return View(_unit.Products.GetEntityById(id));
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var result = _unit.Products.Update(product);

            if (result) //Si es verdadero
            {
                return RedirectToAction("Index"); //Redireccionamos al listado
            }
            else
            {
                return View(product);
            }

        }
    }
}