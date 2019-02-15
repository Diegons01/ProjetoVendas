using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Models.ViewModels
{
    public class RegistroVendasFormViewModel
    {
        public RegistroVenda RegistroVenda { get; set; }
        public ICollection<VendaStatus> VendasStatus { get; set; }
    }
}
