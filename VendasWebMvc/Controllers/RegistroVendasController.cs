using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendasWebMvc.Services;
using VendasWebMvc.Models;
using VendasWebMvc.Models.ViewModels;


namespace VendasWebMvc.Controllers
{
    public class RegistroVendasController : Controller
    {
        private readonly ServiceRegistroVenda _serviceRegistroVenda;

        public RegistroVendasController(VendasWebMvcContext context)
        {
            _serviceRegistroVenda = new ServiceRegistroVenda(context);
        }

        public IActionResult Index()
        {
            var obj = _serviceRegistroVenda.BuscaRegistroVendas();

            return View(obj);
        }
        //Get
        public IActionResult Details()
        {
            return View();
        }
    }
}