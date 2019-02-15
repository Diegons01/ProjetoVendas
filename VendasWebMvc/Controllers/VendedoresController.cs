using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendasWebMvc.Services;
using VendasWebMvc.Models;

namespace VendasWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly ServiceVendedores _serviceVendedores;

        public VendedoresController(VendasWebMvcContext vendasWebMvcContext)
        {
            _serviceVendedores = new ServiceVendedores(vendasWebMvcContext);
        }
        //Get
        public IActionResult Index()
        {
            var obj = _serviceVendedores.BuscaVendedores();

            return View(obj);
        }
        //Get
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _serviceVendedores.CriarNovo(vendedor);
            return RedirectToAction(nameof(Index));
        }
        //Get
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _serviceVendedores.BuscaVendedor(id.Value);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Vendedor vendedor)
        {
            //Validar os Ids 
           
            _serviceVendedores.Atualizar(vendedor);

            return RedirectToAction(nameof(Index));
        }
        //Get
        public IActionResult Delete(int id)
        {
            var obj = _serviceVendedores.BuscaVendedor(id);

            return View(obj);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}