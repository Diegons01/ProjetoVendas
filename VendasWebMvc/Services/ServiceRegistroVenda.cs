using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMvc.Models;

namespace VendasWebMvc.Services
{
    public class ServiceRegistroVenda
    {
        private readonly VendasWebMvcContext _context;

        public ServiceRegistroVenda(VendasWebMvcContext context)
        {
            _context = context;
        }

        public List<RegistroVenda> BuscaRegistroVendas()
        {
            return _context.RegistroVenda.ToList();
        }
    }
}
