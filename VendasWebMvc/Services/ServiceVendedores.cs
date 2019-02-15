using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMvc.Models;

namespace VendasWebMvc.Services
{
    public class ServiceVendedores : Vendedor
    {
        private readonly VendasWebMvcContext _context;

        public ServiceVendedores(VendasWebMvcContext context)
        {
            _context = context;
        }

        public List<Vendedor> BuscaVendedores()
        {
          return _context.Vendedor.Where(x => x.Nome != null).ToList();
        }
        public Vendedor BuscaVendedor(int id)
        {          
            return _context.Vendedor.FirstOrDefault(x => x.Id == id);
        }
        public void CriarNovo(Vendedor vendedor)
        {
            _context.Vendedor.Add(vendedor);
            _context.SaveChanges();
        }
        public void Atualizar(Vendedor vendedor)
        {
            _context.Update(vendedor);
            _context.SaveChanges();
        }
    }
}
