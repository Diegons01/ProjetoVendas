using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Models
{
    public class RegistroVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Total { get; set; }
        public VendaStatus StatusVenda { get; set; }
        public Vendedor Vendedor { get; set; }
        public int VendedorId { get; set; }

        public RegistroVenda()
        {
        }

        public RegistroVenda(int id, DateTime data, double total, VendaStatus statusVenda)
        {
            Id = id;
            Data = data;
            Total = total;
            StatusVenda = statusVenda;
        }
    }
}
